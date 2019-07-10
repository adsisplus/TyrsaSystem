using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class ParrillaLogic
    {
        #region Constructor

        private ParrillaDataAccess CatalogosDA;

        public ParrillaLogic()
        {
            CatalogosDA = new ParrillaDataAccess();

        }

        #endregion
        /// <summary>
        /// Procedimiento que muestra los datos de la parrilla en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosParrilla> ListarDatosParrilla(Int32 intCotizacionID)
        {
            List<DatosParrilla> results = null;
            try
            {
                results = CatalogosDA.ListarDatosParrilla(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Procedimiento que almacena los datos de la parrilla
        /// </summary>
        /// <param name="parrilla"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosParrilla(DatosParrilla parrilla, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intParrillaID;
            int? intDetCotizaID;
            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)parrilla.intCotizacionID);
                intParrillaID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = parrilla.intDetCotizaID;
                detCotizacion.intCotizacionID = parrilla.intCotizacionID;
                detCotizacion.intElementoID = 6; // ID correspondiente a Parrilla
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = parrilla.intCantidadParrilla;
                detCotizacion.decMonto = parrilla.decCostoParrilla;
                detCotizacion.decSubtotal = parrilla.decCostoParrilla * parrilla.intCantidadParrilla;

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(parrilla.intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Almacenamos el ID del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    parrilla.intElementoID = 6;
                    parrilla.intDetCotizaID = intDetCotizaID;
                    parrilla.sintPinturaID = parrilla.sintPinturaID;
                    // Procedeimos a realizar el almacenado de la información
                    result = (new SistemasTyrsaLogic()).setDatosParrilla(parrilla, tinOpcion);
                    if (result.vchResultado != "NOK")
                    {
                        intParrillaID = Convert.ToInt32(result.vchResultado);
                        if ((sistema.intParrillaID == null || sistema.intParrillaID == 0) || tinOpcion == 3)
                        {
                            // En caso de realizar la baja, establecemos el valor a 0
                            if (tinOpcion == 3)
                                sistema.intParrillaID = 0;
                            else
                                sistema.intParrillaID = intParrillaID;

                            sistema.intTipoElementoAlmacenID = 17;
                            sistema.intCotizacionID = parrilla.intCotizacionID;

                            result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza la baja lógica y física (en caso de existir error) en los 
        /// datos de la parrilla
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = realiza el borrado físico de los datos
        ///                         0 = realiza el borrado lógico de los datos</param>
        /// <returns></returns>
        public Resultado setBajaParrilla(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setBajaParrilla(intDetCotizaID, bitRollBack);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
