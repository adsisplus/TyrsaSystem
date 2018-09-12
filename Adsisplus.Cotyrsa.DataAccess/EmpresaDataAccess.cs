using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class EmpresaDataAccess
    {
        public List<Empresa> ListarDatosPersona(Int32 @intEmpresaID, Int16 @sintTipoEmpresaID)
        {
            List<Empresa> results = new List<Empresa>();
            try
            {
                using (EmpresaDataContext dc = new EmpresaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarEmpresa(@intEmpresaID, @sintTipoEmpresaID)
                                select new Empresa()
                                {
                                    intEmpresaID = item.intEmpresaID,
                                    vchTipoEmpresa = item.vchTipoEmpresa,
                                    vchNombre = item.vchNombre,
                                    vchCorreo = item.vchCorreo,
                                    vchCorreoFacturacion = item.vchCorreoFacturacion,
                                    vchCondisionesGenerales = item.vchCondisionesGenerales,
                                    bitEsCliente = item.bitEsCliente,
                                    bitActivo = item.bitActivo,
                                    bitEsProveedor = item.bitEsProveedor

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
