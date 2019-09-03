using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class GuiaEntradaLogic
    {
        private GuiaEntradaDataAccess GuiaEntradaDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public GuiaEntradaLogic()
        {
            GuiaEntradaDA = new GuiaEntradaDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos Guia Entrada
        /// </summary>
        /// <param name="intGuiaEntradaID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosGuiaEntrada> ListarDatosGuiaEntrada(int intGuiaEntradaID, int intDetCotizaID)
        {
            List<DatosGuiaEntrada> result = new List<DatosGuiaEntrada>();
            try
            {
                result = GuiaEntradaDA.ListarDatosGuiaEntrada(intGuiaEntradaID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos Guia Entrada
        /// </summary>
        /// <param name="guia"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosGuiaEntrada(DatosGuiaEntrada guia, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 23; // Falta definir el ID
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = guia.intCantidad;
                detCotizacion.decMonto = guia.decPrecioTotal;
                detCotizacion.decSubtotal = Decimal.Round((Math.Truncate(100 * guia.decPrecioTotal.Value) / 100) * guia.intCantidad.Value);

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    guia.intDetCotizaID = intDetCotizaID;

                    List<DatosGuiaEntrada> ListGuia = new List<DatosGuiaEntrada>();
                    DatosGuiaEntrada _guia = new DatosGuiaEntrada();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListGuia = ListarDatosGuiaEntrada((int)guia.intGuiaEntradaID, intDetCotizaID);
                    // Validamos si existe registro
                    if (ListGuia.Count() > 0)
                        _guia = ListGuia.First();
                    else
                        _guia.intGuiaEntradaID= 0;
                    // Actualizamos la información
                    _guia.bitActivo = guia.bitActivo;
                    _guia.decLargo = guia.decLargo;
                    _guia.decPrecioTotal = guia.decPrecioTotal;
                    _guia.decPrecioUnitario = guia.decPrecioUnitario;
                    _guia.intCantidad = guia.intCantidad;
                    _guia.intCotizacionID = intCotizacionID;
                    _guia.intDetCotizaID = intDetCotizaID;
                    _guia.intElementoID = 23; // id pendiente
                    _guia.sintPinturaID = guia.sintPinturaID;

                    //Realizamos el registro de los datos
                    result = (new DriveInLogic()).setDatosGuiaEntrado(_guia, tinOpcion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
