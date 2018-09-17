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
        public List<Direccion> ListarDatosPersona(Int32 @intDireccionID, Int32 @intMunicipioID, Int32 @intEstadoID, Int32 @intLocalidadID, Int32 @intTipoDomicilioID)
        {
            List<Direccion> results = new List<Direccion>();
            try
            {
                using (DireccionDataContext dc = new DireccionDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDireccion(@intDireccionID, @intMunicipioID, @intEstadoID, @intLocalidadID, @intTipoDomicilioID)
                                select new Direccion()
                                {
                                    intDireccionID = item.intDireccionID,
                                    vchMunicipio = item.vchMunicipio,
                                    vchEstado = item.vchEstado,
                                    vchLocalidad = item.vchLocalidad,
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
