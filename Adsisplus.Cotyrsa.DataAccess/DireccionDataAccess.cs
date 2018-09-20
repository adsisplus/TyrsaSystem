using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class DireccionDataAccess
    {
        public List<Direccion> ListarDireccion(Int32 intDireccionID, Int32 intPersonaID, Int32 intEmpresaID, Int32 intTipoDomicilioID)
        {
            List<Direccion> results = new List<Direccion>();
            try
            {
                using (DireccionDataContext dc = new DireccionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDireccion(intDireccionID, intPersonaID, intEmpresaID, intTipoDomicilioID)
                                select new Direccion()
                                {
                                    intDireccionID = item.intDireccionID,
                                    intMunicipioID = item.intMunicipioID,
                                    vchMunicipio = item.vchMunicipio,
                                    intEstadoID = item.intEstadoID,
                                    vchEstado = item.vchEstado,
                                    intLocalidadID = item.intLocalidadID,
                                    vchLocalidad = item.vchLocalidad,
                                    intTipoDomicilioID = item.intTipoDomicilioID,
                                    vchTipoDomicilio = item.vchTipoDomicilio,
                                    vchCalle = item.vchCalle,
                                    vchNumExterior = item.vchNumExterior,
                                    vchNumInterior = item.vchNumInterior,
                                    vchColonia = item.vchColonia,
                                    vchCP = item.vchCP,
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
        /// <summary>
        /// Permite realizar el alta, modificación o baja de los datos de domicilio
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        public Resultado setDomicilio(Direccion direccion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (DireccionDataContext dc = new DireccionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDomicilio(direccion.intDireccionID, direccion.intMunicipioID, direccion.intEstadoID, direccion.intLocalidadID,
                        direccion.intTipoDomicilioID, direccion.vchCalle, direccion.vchNumExterior, direccion.vchNumInterior, direccion.vchColonia, direccion.vchCP,
                        direccion.bitActivo, (byte)tinOpcion)
                                select new Resultado()
                                {
                                    vchResultado = item.vchResultado,
                                    vchDescripcion = item.vchDescripcion
                                };
                    result = query.First();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
