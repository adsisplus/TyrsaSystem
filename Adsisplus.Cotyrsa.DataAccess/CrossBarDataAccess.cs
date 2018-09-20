using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
namespace Adsisplus.Cotyrsa.DataAccess
{
   public class CrossBarDataAccess
    {
       
            public List<DatosCrossBar> ListarDatosPanel(Int32 intDatosCrossBarID, Int32 intElementoID, Int32 intDatoMarcoID)
            {
                List<DatosCrossBar> results = new List<DatosCrossBar>();
                try
                {
                    using (CrossBarDataContext dc = new CrossBarDataContext(Helper.ConnectionString()))
                    {
                        var query = from item in dc.stp_ListarDatosCrossBar(intDatosCrossBarID, intElementoID, intDatoMarcoID)
                                    select new DatosCrossBar()
                                    {
                                        intDatosCrossBarID = item.intDatosCrossBarID,
                                        vchElemento = item.vchElemento,
                                        sintCantidadDatoMarco = item.sintCantidadDatoMarco,
                                        decAnchoCrossBar = item.decAnchoCrossBar,
                                        bitConectorVigaCrossbar = item.bitConectorVigaCrossbar,
                                        intCantidadNivelCrossbar = item.intCantidadNivelCrossbar,
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
