using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class AtirantadoLogic
    {
        private AtirantadoDataAccess AtirantadoDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public AtirantadoLogic()
        {
            AtirantadoDA = new AtirantadoDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos Atirantado
        /// </summary>
        /// <param name="intAtirantadoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosAtirantado> ListarDatosAtirantado(int intAtirantadoID, int intDetCotizaID)
        {
            List<DatosAtirantado> result = new List<DatosAtirantado>();
            try
            {
                result = AtirantadoDA.ListarDatosAtirantado(intAtirantadoID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos atirantado
        /// </summary>
        /// <param name="atirantado"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAtirantado(DatosAtirantado atirantado, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 19;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = atirantado.intCantidad;
                detCotizacion.decMonto = atirantado.decPrecioVentaTotal;
                detCotizacion.decSubtotal = Decimal.Round((Math.Truncate(100 * atirantado.decPrecioVentaTotal.Value) / 100) * atirantado.intCantidad.Value);

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));

                if (result.vchResultado != "NOK")
                {
                    // Establecemos el ID del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    atirantado.intDetCotizaID = intDetCotizaID;

                    List<DatosAtirantado> ListAtirantado = new List<DatosAtirantado>();
                    DatosAtirantado _atirantado = new DatosAtirantado();
                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListAtirantado = ListarDatosAtirantado((int)atirantado.intAtirantadoID, intDetCotizaID);
                    //Validamos si existe registro
                    if (ListAtirantado.Count > 0)
                        _atirantado = ListAtirantado.First();
                    else
                        // En caso contrario, establecemos el valor 0
                        _atirantado.intAtirantadoID = 0;
                    // Actualizamos la información
                    _atirantado.bitActivo = atirantado.bitActivo;
                    _atirantado.decLargo = atirantado.decLargo;
                    _atirantado.decLongitud = atirantado.decLongitud;
                    _atirantado.decPesoTotal = atirantado.decPesoTotal;
                    _atirantado.decPesoUnitario = atirantado.decPesoUnitario;
                    _atirantado.decPrecioVentaTotal = atirantado.decPrecioVentaTotal;
                    _atirantado.decPrecioVentaUnitario = atirantado.decPrecioVentaUnitario;
                    _atirantado.intCalibreID = atirantado.intCalibreID;
                    _atirantado.intCantidad = atirantado.intCantidad;
                    _atirantado.intCotizacionID = intCotizacionID;
                    _atirantado.intDetCotizaID = intDetCotizaID;
                    _atirantado.intElementoID = 19;
                    _atirantado.sintPinturaID = atirantado.sintPinturaID;

                    // Realizamos el registro del atirantado
                    result = (new DriveInLogic()).setDatosAtirantado(_atirantado, tinOpcion);

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
