using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class RielTarimaLogic
    {
        private RielTarimaDataAccess RielTarimaDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public RielTarimaLogic()
        {
            RielTarimaDA = new RielTarimaDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos Riel Tarima
        /// </summary>
        /// <param name="intRielTarimaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosRielTarima> ListarDatosRielTarima(int intRielTarimaID, int intCotizacionID)
        {
            List<DatosRielTarima> result = new List<DatosRielTarima>();
            try
            {
                result = RielTarimaDA.ListarDatosRielTarima(intRielTarimaID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de Riel Tarima en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionRielDeCarga> ListarSeleccionRielTarima(int intCotizacionID)
        {
            List<SeleccionRielDeCarga> result = new List<SeleccionRielDeCarga>();
            try
            {
                result = RielTarimaDA.ListarSeleccionRielTarima(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion riel de carga
        /// </summary>
        /// <param name="decPeso"></param>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        public List<SeleccionRielDeCarga> ListarDriveInRielDeCarga(decimal decPeso, bool bitEsEstructural)
        {
            List<SeleccionRielDeCarga> result = new List<SeleccionRielDeCarga>();
            try
            {
                result = RielTarimaDA.ListarDriveInRielDeCarga(decPeso, bitEsEstructural);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta o modificación de los datos Riel Tarima
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRielTarima(DatosRielTarima riel, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 17;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = riel.intCantidad;
                detCotizacion.decMonto = tinOpcion == 3 ? 0 : riel.seleccion.decPrecioFinal;
                detCotizacion.decSubtotal = tinOpcion == 3 ? 0 : riel.seleccion.decPrecioVentaTotal;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    riel.intDetCotizaID = intDetCotizaID;

                    List<DatosRielTarima> ListRiel = new List<DatosRielTarima>();
                    DatosRielTarima _riel = new DatosRielTarima();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListRiel = ListarDatosRielTarima((int)riel.intRielTarimaID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListRiel.Count() > 0)
                        _riel = ListRiel.First();
                    else
                        _riel.intRielTarimaID = 0;

                    _riel.intCotizacionID = intCotizacionID;
                    _riel.intDetCotizaID = intDetCotizaID;
                    _riel.seleccion = new SeleccionRielDeCarga();
                    if (tinOpcion != 3)
                    {
                        // Actualizamos la información
                        _riel.bitActivo = riel.bitActivo;
                        _riel.decCarga = riel.decCarga;
                        _riel.decLargo = riel.decLargo;
                        _riel.intCantidad = riel.intCantidad;

                        _riel.intElementoID = 17;
                        _riel.intRielTarimaID = riel.intRielTarimaID;
                        _riel.sintPinturaID = riel.sintPinturaID;
                        _riel.sintRielTarimaID = riel.sintRielTarimaID;
                        _riel.sintTipoRielTarimaID = riel.sintTipoRielTarimaID;

                        // Establecemos los datos de la selección
                        _riel.seleccion = riel.seleccion;
                    }
                    //Realizamos el registro de los datos
                    result = (new DriveInLogic()).setDatosRielTarima(_riel, tinOpcion);
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
