using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.CatalogoService.Contract
{
    [ServiceContract]
    interface ICatalogoGeneralServices
    {
        /// <summary>
        /// Obtiene la lista de localidades en base al municipio
        /// </summary>
        /// <param name="int_MunicipioID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Localidad> ListarCatLocalidad(Int32 @int_MunicipioID);
        /// <summary>
        /// Obtiene la lista de estados de la república mexicana
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatEstado();
        /// <summary>
        /// Obtiene la lista de municipios en base al estado seleccionado
        /// </summary>
        /// <param name="intEstadoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Municipio> ListarCatMunicipio(Int32 @intEstadoID);
        /// <summary>
        /// Obtiene la lista de personalidades
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatPersonalidad();
        /// <summary>
        /// Obtiene la lista de prioridades
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatPrioridad();
        /// <summary>
        /// Obtiene la lista de tipos de domicilios
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoDomicilio();
        /// <summary>
        /// Obtiene la lista de tipos de empresas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoEmpresa();
        /// <summary>
        /// Obtiene la lista de tipos de personas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoPersona();
    }
}
