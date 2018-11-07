using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;


namespace Adsisplus.Cotyrsa.BusinessLogic
{
  public class MarcosLogic
    {
        #region Constructor

        private MarcosDataAccess CatalogosDA;

        public MarcosLogic()
        {
            CatalogosDA = new MarcosDataAccess();

        }

        #endregion

        public List<Configuracion_Marco> ConfiguraMarco(Int32 intConfiguraMarcoID, Int32 intElementoID, Int16 sintTipoMarcoID, Int32 intAlturaMarcoID, Int16 sintFondoMarcoID, 
            Int32 intSKUID, Int16 sintFactorMarcoID, decimal decFondoMarco)
        {
            List<Configuracion_Marco> results = null;
            try
            {
                results = CatalogosDA.ConfiguraMarco(intConfiguraMarcoID, intElementoID, sintTipoMarcoID, intAlturaMarcoID, sintFondoMarcoID, intSKUID, sintFactorMarcoID, decFondoMarco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<RelSistemaCargaMarcoPoste> RelSistemaCargaMarcoPoste(Int16 sintSistemaCargaMarcoID, Int32 intSubProductoID, Int32 intCargaPosteID, Int32 intCargaMarcoID)
        {
            List<RelSistemaCargaMarcoPoste> results = null;
            try
            {
                results = CatalogosDA.RelSistemaCargaMarcoPoste(sintSistemaCargaMarcoID, intSubProductoID, intCargaPosteID, intCargaPosteID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<DatosMarco> ListarDatosMarco(Int32 intDatoMarcoID, Int32 intCotizacionID, Int32 intElementoID, Int16 sintPinturaID)
        {
            List<DatosMarco> results = null;
            try
            {
                results = CatalogosDA.ListarDatosMarco(intDatoMarcoID, intCotizacionID, intElementoID, sintPinturaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<FondoMarco> ListarFondoMarco(Int32 sintFondoMarcoID, Int32 sintTipoMarcoID, decimal decFondoMarco, int intCalibreAceroID)
        {
            List<FondoMarco> results = null;
            try
            {
                results = CatalogosDA.ListarFondoMarco(sintFondoMarcoID, sintTipoMarcoID, decFondoMarco, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public Resultado ActualizaFactorMarco(Int16 sintFondoMarcoID, Decimal decCostoLamina, Decimal decCostoSolera, Decimal decFactorAcero, byte tinOpcion)
        {
            Resultado results = new Resultado();
            try
            {
                results = CatalogosDA.ActualizaFactorMarco(sintFondoMarcoID, decCostoLamina, decCostoSolera, decFactorAcero, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Obtiene la lista el catálogo de factores para los marcos
        /// </summary>
        /// <returns></returns>
        public List<FactorMarco> ListarCatFactorMarco()
        {
            List<FactorMarco> result = new List<FactorMarco>();
            try
            {
                result = CatalogosDA.ListarCatFactorMarco();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Devuelve el catálogo de la capacidad de carga para un marco
        /// </summary>
        /// <returns></returns>
        public List<CargaMarco> ListarCatCargaMarco(int intCargaMarcoID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaMarco> result = new List<CargaMarco>();
            try
            {
                result = CatalogosDA.ListarCatCargaMarco(intCargaMarcoID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Obtiene la capacidad de carga de los postes
        /// </summary>
        /// <param name="intCargaPosteID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        public List<CargaPoste> ListarCatCargaPoste(int intCargaPosteID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaPoste> result = new List<CargaPoste>();
            try
            {
                result = CatalogosDA.ListarCatCargaPoste(intCargaPosteID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Permite actualizar los factores del marco
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public Resultado setFondoMarco(FondoMarco factor)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setFondoMarco(factor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
