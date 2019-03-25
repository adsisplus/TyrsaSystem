using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;


namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class DistanciadorLogic
    {
        #region Constructor

        private DistanciadorDataAccess CatalogosDA;

        public DistanciadorLogic()
        {
            CatalogosDA = new DistanciadorDataAccess();

        }

        #endregion
        /// <summary>
        /// Procedimiento que lista los datos del distanciador en base a la cotización
        /// </summary>
        /// <param name="intDistanciadorID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        public List<DatosDistanciador> ListarDatosDistanciador(Int32 intDistanciadorID, Int32 intCotizacionID, int intDetCotizaID, Int32 intElementoID)
        {
            List<DatosDistanciador> results = null;
            try
            {
                results = CatalogosDA.ListarDatosDistanciador(intDistanciadorID, intCotizacionID, intDetCotizaID, intElementoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Procedimiento que almacena los datos del Distanciador
        /// </summary>
        /// <param name="distanciador"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDistanciador(DatosDistanciador distanciador, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intDistanciadorID;
            int? intDetCotizaID;
            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)distanciador.intCotizacionID);
                intDistanciadorID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = distanciador.intDetCotizaID;
                detCotizacion.intCotizacionID = distanciador.intCotizacionID;
                detCotizacion.intElementoID = 5; // ID correspondiente a Distanciador
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = distanciador.intCantidadDistanciador;
                detCotizacion.decMonto = 0;
                detCotizacion.decSubtotal = 0 * distanciador.intCantidadDistanciador;

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(distanciador.intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Almacenamos el ID del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    distanciador.intDetCotizaID = intDetCotizaID;
                    // Procedeimos a realizar el almacenado de la información
                    result = (new SistemasTyrsaLogic()).setDatosDistanciador(distanciador, tinOpcion);
                    if (result.vchResultado != "NOK")
                    {
                        intDistanciadorID = Convert.ToInt32(result.vchResultado);
                        if ((sistema.intDistanciadorID == null || sistema.intDistanciadorID == 0) || tinOpcion == 3)
                        {
                            // En caso de realizar la baja, establecemos el valor a 0
                            if (tinOpcion == 3)
                                sistema.intDistanciadorID = 0;
                            else
                                sistema.intDistanciadorID = intDistanciadorID;

                            sistema.intTipoElementoAlmacenID = 17;
                            sistema.intCotizacionID = distanciador.intCotizacionID;

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
    }
}
