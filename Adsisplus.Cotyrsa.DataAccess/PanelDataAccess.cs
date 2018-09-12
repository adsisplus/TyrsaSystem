using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
    
    public class PanelDataAccess
    {
        public List<DatosPanel> ListarDatosPanel(Int32 @intDatosPanelID, Int32 @intElementoID, Int32 @intDatoMarcoID, Int16 @sintPinturaID)
        {
            List<DatosPanel> results = new List<DatosPanel>();
            try
            {
                using (PanelesDataContext dc = new PanelesDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPanel(@intDatosPanelID, @intElementoID, @intDatoMarcoID, @sintPinturaID)
                                select new DatosPanel()
                                {
                                    intDatosPanelID = item.intDatosPanelID,
                                    vchElemento = item.vchElemento,
                                    sintCantidadDatoMarco = item.sintCantidadDatoMarco,
                                    vchPintura = item.vchPintura,
                                    decAnchoPanel = item.decAnchoPanel,
                                    intCantidadPanel = item.intCantidadPanel,
                                    decCapacidadCargaPanel = item.decCapacidadCargaPanel,
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
