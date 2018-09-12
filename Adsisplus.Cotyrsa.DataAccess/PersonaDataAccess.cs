using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class PersonaDataAccess
    {
        public List<Persona> ListarDatosPersona(Int32 @intPersonaID, Int32 @intTipoPersonaID, Int32 @intEmpresaID)
        {
            List<Persona> results = new List<Persona>();
            try
            {
                using (PersonaDataContext dc = new PersonaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPersona(@intPersonaID, @intTipoPersonaID, @intEmpresaID)
                                select new Persona()
                                {
                                    intPersonaID = item.intPersonaID,
                                    vchTipoPersona = item.vchTipoPersona,
                                    vchNombreEmpresa = item.vchNombreEmpresa,
                                    vchNombreCompleto = item.vchNombreCompleto,
                                    vchNombre = item.vchNombre,
                                    vchApPaterno = item.vchApPaterno,
                                    vchApMaterno = item.vchApMaterno,
                                    datFechaNacimiento = item.datFechaNacimiento,
                                    vchLugarNacimiento = item.vchLugarNacimiento,
                                    vchRFC = item.vchRFC,
                                    vchCURP = item.vchCURP,
                                    sintEdad = item.sintEdad,
                                    vchTelefono = item.vchTelefono,
                                    vchTelefonoMovil = item.vchTelefonoMovil,
                                    vchMail = item.vchMail,
                                    bitActivo = item.bitActivo,
                                    bitCausaRetencion = item.bitCausaRetencion

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

        public List<Persona> ListarRelPersonaDireccionEmpresa(Int32 @intPersonaDomEmpreID, Int32 @intPersonaID, Int32 @intDireccionID, Int32 @intEmpresaID)
        {
            List<Persona> results = new List<Persona>();
            try
            {
                using (PersonaDataContext dc = new PersonaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarRelPersonaDireccionEmpresa(@intPersonaDomEmpreID, @intPersonaID, @intDireccionID, @intEmpresaID)
                                select new Persona()
                                {
                                    intPersonaDomEmpreID = item.intPersonaDomEmpreID,
                                    vchPersona = item.vchPersona,
                                    vchDomicilio = item.vchDomicilio,
                                    vchEmpresa = item.vchEmpresa,
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
