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

        public List<Configuracion_Marco> ConfiguraMarco(Int32 intConfiguraMarcoID, Int32 intElementoID, Int16 sintTipoMarcoID, Int32 intAlturaMarcoID, Int16 sintFondoMarcoID, Int32 intSKUID, Int16 sintFactorMarcoID)
        {
            List<Configuracion_Marco> results = null;
            try
            {
                results = CatalogosDA.ConfiguraMarco(intConfiguraMarcoID, intElementoID, sintTipoMarcoID, intAlturaMarcoID, sintFondoMarcoID, intSKUID, sintFactorMarcoID);
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

        public List<FondoMarco> ListarFondoMarco(Int32 sintFondoMarcoID, Int32 sintTipoMarcoID, decimal decFondoMarco)
        {
            List<FondoMarco> results = null;
            try
            {
                results = CatalogosDA.ListarFondoMarco(sintFondoMarcoID, sintTipoMarcoID, decFondoMarco);
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
    }
}
