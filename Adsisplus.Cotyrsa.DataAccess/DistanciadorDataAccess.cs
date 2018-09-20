using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class DistanciadorDataAccess
    {
        public List<DatosDistanciador> ListarDatosPanel(Int32 intDistanciadorID, Int32 intCotizacionID, Int32 intElementoID)
        {
            List<DatosDistanciador> results = new List<DatosDistanciador>();
            try
            {
                using (DistanciadorDataContext dc = new DistanciadorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosDistanciador(intDistanciadorID, intCotizacionID, intElementoID)
                                select new DatosDistanciador()
                                {
                                    intDistanciadorID = item.intDistanciadorID,
                                    intCotizacionID = item.intCotizacionID,
                                    vchFolio = item.vchFolio,
                                    vchElemento = item.vchElemento,
                                    intCantidadDistanciador = item.intCantidadDistanciador,
                                    decLargoDistanciador = item.decLargoDistanciador,
                                    bitActivo = item.bitActivo
                                };
                    results.AddRange(query);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
