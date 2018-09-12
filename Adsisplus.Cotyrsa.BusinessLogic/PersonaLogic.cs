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

        public List<Persona> ListarDatosPersona(Int32 @intPersonaID, Int32 @intTipoPersonaID, Int32 @intEmpresaID)
        {
            List<Persona> results = null;
            try
            {
                results = CatalogosDA.ListarDatosPersona(@intPersonaID, @intTipoPersonaID, @intEmpresaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Persona> ListarRelPersonaDireccionEmpresa(Int32 @intPersonaDomEmpreID, Int32 @intPersonaID, Int32 @intDireccionID, Int32 @intEmpresaID)
        {
            List<Persona> results = null;
            try
            {
                results = CatalogosDA.ListarRelPersonaDireccionEmpresa(@intPersonaDomEmpreID, @intPersonaID, @intDireccionID, @intEmpresaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }


    }
}
