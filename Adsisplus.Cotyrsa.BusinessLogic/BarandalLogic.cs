using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class BarandalLogic
    {
        private BarandalDataAccess BarandalDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public BarandalLogic()
        {
            BarandalDA = new BarandalDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos Barandal
        /// </summary>
        /// <param name="intDatosBarandalID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosBarandal> ListarDatosBarandal(int intDatosBarandalID, int intDetCotizaID)
        {
            List<DatosBarandal> result = new List<DatosBarandal>();
            try
            {
                result = BarandalDA.ListarDatosBarandal(intDatosBarandalID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, baja o modificación de los datos de barandal
        /// </summary>
        /// <param name="barandal"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBarandal(DatosBarandal barandal, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 2; // Falta definir el ID
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = Convert.ToInt32(barandal.decCantidad);
                detCotizacion.decMonto = barandal.decPrecioTotal;
                detCotizacion.decSubtotal = Decimal.Round((Math.Truncate(100 * barandal.decPrecioTotal.Value) / 100) * barandal.decCantidad.Value);

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    barandal.intDetCotizaID = intDetCotizaID;

                    List<DatosBarandal> ListBarandal = new List<DatosBarandal>();
                    DatosBarandal _barandal = new DatosBarandal();

                    //Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListBarandal = ListarDatosBarandal((int)barandal.intDatosBarandalID, intDetCotizaID);
                    //Validamos si existe registro
                    if (ListBarandal.Count > 0)
                        _barandal = ListBarandal.First();
                    else
                        _barandal.intDatosBarandalID = 0;
                    // Actualizamos la información
                    _barandal.intCotizacionID = intCotizacionID;
                    _barandal.intDetCotizaID = intDetCotizaID;
                    _barandal.intElementoID = 0; // Hace falta definir el id del elemento
                    _barandal.sintPinturaID = barandal.sintPinturaID;
                    _barandal.bitActivo = barandal.bitActivo;
                    _barandal.decCantidad = barandal.decCantidad;
                    _barandal.decLargo = barandal.decLargo;
                    _barandal.decPrecioTotal = barandal.decPrecioTotal;
                    _barandal.decPrecioUnitario = barandal.decPrecioUnitario;

                    // Realizamos el registro del atirantado
                    result = (new DriveInLogic()).setDatosBarandal(_barandal, tinOpcion);
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
