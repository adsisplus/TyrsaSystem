using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
  public class PersonaLogic
    {
        #region Constructor

        private PersonaDataAccess CatalogosDA;

        public PersonaLogic()
        {
            CatalogosDA = new PersonaDataAccess();

        }

        #endregion

        public List<Persona> ListarDatosPersona(Int32 intPersonaID, Int32 intTipoPersonaID, Int32 intEmpresaID)
        {
            List<Persona> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPersona(intPersonaID, intTipoPersonaID, intEmpresaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Persona> ListarRelPersonaDireccionEmpresa(Int32 intPersonaDomEmpreID, Int32 intPersonaID, Int32 intDireccionID, Int32 intEmpresaID)
        {
            List<Persona> results = null;
            try
            {
                results = CatalogosDA.ListarRelPersonaDireccionEmpresa(intPersonaDomEmpreID, intPersonaID, intDireccionID, intEmpresaID);
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
                result = CatalogosDA.setPersona(persona, tinOpcion);
            }
            catch (Exception ex)
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
                result = CatalogosDA.setRelaciónPersonaDomicilioEmpresa(relPersonaDomicilioEmpresa, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
