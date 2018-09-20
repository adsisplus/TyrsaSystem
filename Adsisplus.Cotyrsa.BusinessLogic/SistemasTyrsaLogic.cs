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

        public List<RelSistemaSelectivo> ListarRelSistemaSelectivo(Int32 intCotizacionID, Int32 intTipoElementoCoti_Producto, Int32 intTipoElementoID, Int32 intTipoElementoAlmacenID, Int32 intConfiguraMarcoID, Int32 intConfiguraVigaID, Int32 intDatoMarcoID, Int32 intDatosVigaID, Int32 intDatosPanelID, Int32 intDatosCrossBarID, Int32 intDistanciadorID, Int32 intParrillaID, Int32 intVigaTopeID, Int32 intProtectorPosteID, Int32 intProtectorBateriaID, Int16 sintSistemaCargaMarcoID, DateTime datFechaAlta)
        {
            List<RelSistemaSelectivo> results = null;
            try
            {
                results = CatalogosDA.ListarRelSistemaSelectivo(intCotizacionID, intTipoElementoCoti_Producto, intTipoElementoID, intTipoElementoAlmacenID, intConfiguraMarcoID, intConfiguraVigaID, intDatoMarcoID, intDatosVigaID, intDatosPanelID, intDatosCrossBarID, intDistanciadorID, intParrillaID, intVigaTopeID, intProtectorPosteID, intProtectorBateriaID, sintSistemaCargaMarcoID, datFechaAlta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
