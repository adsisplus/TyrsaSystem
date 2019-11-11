using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class ConectorLogic
    {
        private ConectorDataAccess ConectorDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public ConectorLogic()
        {
            ConectorDA = new ConectorDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los conectores en base al calibre y cantidad
        /// </summary>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="intCantidad"></param>
        /// <returns></returns>
        public List<SeleccionConector> ListarConectorCartonFlow(short intCalibreAceroID, int intCantidad)
        {
            List<SeleccionConector> result = new List<SeleccionConector>();
            try
            {
                result = ConectorDA.ListarConectorCartonFlow(intCalibreAceroID, intCantidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de conector de carton flow en base al ID de la cotización o al Id del conector
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatosConectorCFID"></param>
        /// <returns></returns>
        public List<DatosConectorCartonFlow> ListarDatosConectorCartonFlow(int intCotizacionID, int intDatosConectorCFID)
        {
            List<DatosConectorCartonFlow> result = new List<DatosConectorCartonFlow>();
            try
            {
                result = ConectorDA.ListarDatosConectorCartonFlow(intCotizacionID, intDatosConectorCFID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los conectores carton flow
        /// </summary>
        /// <param name="conector"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosConectorCartonFlow(DatosConectorCartonFlow conector, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 29; // // FALTA INGREGAR EL ELEMENTO AL CATÁLOGO
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = 0;
                detCotizacion.decMonto = conector.decPrecioUnitario;
                detCotizacion.decSubtotal = conector.decPrecioTotal;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    conector.intDetCotizaID = intDetCotizaID;

                    List<DatosConectorCartonFlow> ListConector = new List<DatosConectorCartonFlow>();
                    DatosConectorCartonFlow _conector = new DatosConectorCartonFlow();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListConector = ListarDatosConectorCartonFlow(intDetCotizaID, (int)conector.intDatosConectorCFID);
                    // Validamos si existe registro
                    if (ListConector.Count() > 0)
                        _conector = ListConector.First();
                    else
                        _conector.intDatosConectorCFID = 0;

                    conector.intCotizacionID = intCotizacionID;
                    conector.intDetCotizaID = intDetCotizaID;
                    // Actualizamos la información
                    _conector = conector;
                    //_conector.intElementoID = 29; // FALTA INGREGAR EL ELEMENTO AL CATÁLOGO

                    // Realizamos el registro del Carton Flow
                    result = (new CartonFlowLogic()).setDatosConectorCartonFlow(conector, tinOpcion);
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
