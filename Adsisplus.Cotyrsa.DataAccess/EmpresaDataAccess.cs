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
        public List<Empresa> ListarEmpresa(Int32 intEmpresaID, Int16 sintTipoEmpresaID)
        {
            List<Empresa> results = new List<Empresa>();
            try
            {
                using (EmpresaDataContext dc = new EmpresaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarEmpresa(intEmpresaID, sintTipoEmpresaID)
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
        /// <summary>
        /// Permite realizar el alta, modificación y baja de la empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setEmpresa(Empresa empresa, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (EmpresaDataContext dc = new EmpresaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setEmpresa(empresa.intEmpresaID, empresa.sintTipoEmpresaID, empresa.vchNombre, empresa.vchCorreo, empresa.vchCorreoFacturacion,
                        empresa.vchCondisionesGenerales, empresa.bitEsCliente, empresa.bitActivo, empresa.bitEsProveedor, (byte)tinOpcion)
                                select new Resultado()
                                {
                                    vchResultado = item.vchResultado,
                                    vchDescripcion = item.vchDescripcion
                                };
                    result = query.First();
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
