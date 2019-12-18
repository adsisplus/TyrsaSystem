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
        /// <summary>
        /// Procedimiento que lista los datos de la empresa en base al usuario y al tipo de empresa
        /// </summary>
        /// <param name="intEmpresaID"></param>
        /// <param name="sintTipoEmpresaID"></param>
        /// <param name="intUsuarioID"></param>
        /// <returns></returns>
        public List<Empresa> ListarEmpresa(Int32 intEmpresaID, Int16 sintTipoEmpresaID, int intUsuarioID)
        {
            List<Empresa> results = new List<Empresa>();
            try
            {
                using (EmpresaDataContext dc = new EmpresaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarEmpresa(intEmpresaID, sintTipoEmpresaID, intUsuarioID)
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
                                    bitEsProveedor = item.bitEsProveedor,
                                    bitCausaRetencion = item.bitCausaRetencion,
                                    sintTipoEmpresaID = item.sintTipoEmpresaID,
                                    vchRFC = item.vchRFC,
                                    vchTelefono = item.vchTelefono
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
                        empresa.vchCondisionesGenerales, empresa.vchTelefono, empresa.vchRFC, empresa.bitEsCliente, empresa.bitActivo, empresa.bitEsProveedor, empresa.bitCausaRetencion, empresa.intUsuarioID, (byte)tinOpcion)
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
