using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class SistemasTyrsaLogic
    {
        #region Constructor

        private SistemasTyrsaDataAccess CatalogosDA;

        public SistemasTyrsaLogic()
        {
            CatalogosDA = new SistemasTyrsaDataAccess();

        }

        #endregion

        //public List<RelSistemaSelectivo> ListarRelSistemaSelectivo(Int32 intCotizacionID, Int32 intTipoElementoCoti_Producto, Int32 intTipoElementoID, Int32 intTipoElementoAlmacenID, Int32 intConfiguraMarcoID, Int32 intConfiguraVigaID, Int32 intDatoMarcoID, Int32 intDatosVigaID, Int32 intDatosPanelID, Int32 intDatosCrossBarID, Int32 intDistanciadorID, Int32 intParrillaID, Int32 intVigaTopeID, Int32 intProtectorPosteID, Int32 intProtectorBateriaID, Int16 sintSistemaCargaMarcoID, DateTime datFechaAlta)
        //{
        //    List<RelSistemaSelectivo> results = null;
        //    try
        //    {
        //        results = CatalogosDA.ListarRelSistemaSelectivo(intCotizacionID, intTipoElementoCoti_Producto, intTipoElementoID, intTipoElementoAlmacenID, intConfiguraMarcoID, intConfiguraVigaID, intDatoMarcoID, intDatosVigaID, intDatosPanelID, intDatosCrossBarID, intDistanciadorID, intParrillaID, intVigaTopeID, intProtectorPosteID, intProtectorBateriaID, sintSistemaCargaMarcoID, datFechaAlta);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return results;
        //}
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosMarco"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosMarco(DatosMarco datosMarco, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosMarco(datosMarco, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosViga"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViga(DatosViga datosViga, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosViga(datosViga, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos panel
        /// </summary>
        /// <param name="datosPanel"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPanel(DatosPanel datosPanel, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosPanel(datosPanel, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos de Cross Bar
        /// </summary>
        /// <param name="datosCrossBar"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosCrossBar(DatosCrossBar datosCrossBar, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosCrossBar(datosCrossBar, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos de distanciador
        /// </summary>
        /// <param name="datosDistanciador"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDistanciador(DatosDistanciador datosDistanciador, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosDistanciador(datosDistanciador, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Parrilla
        /// </summary>
        /// <param name="datosParrilla"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosParrilla(DatosParrilla datosParrilla, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosParrilla(datosParrilla, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Viga tope
        /// </summary>
        /// <param name="datosVigaTope"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosVigaTope(DatosVigaTope datosVigaTope, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosVigaTope(datosVigaTope, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, modificación o baja a los datos protector poste
        /// </summary>
        /// <param name="datosProtector"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorPoste(DatosProtectorBase datosProtector, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosProtectorPoste(datosProtector, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Realiza el alta, baja o modificación a los datos de Protector Batería
        /// </summary>
        /// <param name="datosProtectorBateria"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorBateria(DatosProtectorBateria datosProtectorBateria, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosProtectorBateria(datosProtectorBateria, sintOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que muestra los datos de tornilleria
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="bitEstructural"></param>
        /// <param name="bitEsCuadruple"></param>
        /// <returns></returns>
        public List<DatosTornilleria> ListarDatosTornilleria(int intCotizacionID, bool bitEstructural, bool bitEsCuadruple)
        {
            List<DatosTornilleria> result = new List<DatosTornilleria>();
            try
            {
                // Buscamos la información del sistema selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo(intCotizacionID);
                if (sistema.intDatoMarcoID != null || sistema.intDatoMarcoID != 0)
                {
                    // Obtenemos los datos del marco
                    List<DatosMarco> lstMarco = (new MarcosLogic()).ListarDatosMarco((int)sistema.intDatoMarcoID, intCotizacionID);
                    if (lstMarco.Count > 0)
                        result = CatalogosDA.ListarDatosTornilleria((int)lstMarco.First().intConfiguraMarcoID, intCotizacionID, bitEstructural, bitEsCuadruple);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que devuelve los datos de tornillería en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosTornilleria> ListarTornillosSelectivoCotizacion(int intCotizacionID)
        {
            List<DatosTornilleria> result = new List<DatosTornilleria>();
            try
            {
                result = CatalogosDA.ListarTornillosSelectivoCotizacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
