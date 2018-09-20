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
                                    intTipoPersonaID = item.intTipoPersonaID,
                                    vchTipoPersona = item.vchTipoPersona,
                                    intEmpresaID = item.intEmpresaID,
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
        /// <summary>
        /// Permite el alta, modificación o baja de la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setPersona(Persona persona, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (PersonaDataContext dc = new PersonaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setPersona(persona.intPersonaID, persona.intTipoPersonaID, persona.intEmpresaID, persona.vchNombreCompleto, persona.vchNombre,
                        persona.vchApPaterno, persona.vchApMaterno, persona.datFechaNacimiento, persona.vchLugarNacimiento, persona.vchRFC, persona.vchCURP, persona.sintEdad,
                        persona.vchTelefono, persona.vchTelefonoMovil, persona.vchMail, persona.bitActivo, persona.bitCausaRetencion, (byte)tinOpcion)
                                select new Resultado
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
        /// <summary>
        /// Realiza alta, modificación y baja de la relación Persona, Domicilio y Empresa
        /// </summary>
        /// <param name="relPersonaDomicilioEmpresa"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setRelaciónPersonaDomicilioEmpresa(RelPersonaDomicilioEmpresa relPersonaDomicilioEmpresa, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (PersonaDataContext dc = new PersonaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setRelaciónPersonaDomicilioEmpresa(relPersonaDomicilioEmpresa.intPersonaDomEmpreID, relPersonaDomicilioEmpresa.intDireccionID,
                        relPersonaDomicilioEmpresa.intDireccionID, relPersonaDomicilioEmpresa.intEmpresaID, relPersonaDomicilioEmpresa.bitActivo, (byte)tinOpcion)
                                select new Resultado
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
