using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessEntities.Catalogos;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CatalogoGeneralServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CatalogoGeneralServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CatalogoGeneralServices.svc o CatalogoGeneralServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CatalogoGeneralServices : ICatalogoGeneralServices
    {
        #region Catálogos iniciales

        /// <summary>
        /// Obtiene la lista de estados de la república mexicana
        /// </summary>
        /// <returns></returns>

        public List<Catalogo> ListarCatEstado()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatEstado();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de localidades en base al municipio seleccionado.
        /// </summary>
        /// <param name="int_MunicipioID"></param>
        /// <returns></returns>
        public List<Localidad> ListarCatLocalidad(int int_MunicipioID)
        {
            List<Localidad> result = new List<Localidad>();
            try
            {
                result = (new CatalogoLogic()).ListarCatLocalidad(int_MunicipioID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de municipios en base a un estado seleccionado
        /// </summary>
        /// <param name="intEstadoID"></param>
        /// <returns></returns>
        public List<Municipio> ListarCatMunicipio(int intEstadoID)
        {
            List<Municipio> result = new List<Municipio>();
            try
            {
                result = (new CatalogoLogic()).ListarCatMunicipio(intEstadoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de personalidades.
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPersonalidad()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatPersonalidad();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de prioridades.
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPrioridad()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatPrioridad();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de domicilios
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoDomicilio()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoDomicilio();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de empresa
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoEmpresa()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoEmpresa();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de personas
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoPersona()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoPersona();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de catálogos
        /// </summary>
        /// <returns></returns>
        public List<DatosViaticos> ListarViatico()
        {
            List<DatosViaticos> result = new List<DatosViaticos>();
            try
            {
                result = (new CatalogoLogic()).ListarViatico();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de destino flete
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatDestinoFlete()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatDestinoFlete();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene la lista de catálogo flete
        /// </summary>
        /// <param name="sintDestinoFleteID"></param>
        /// <returns></returns>
        public List<DatosFlete> ListarCatFlete(short sintDestinoFleteID)
        {
            List<DatosFlete> result = new List<DatosFlete>();
            try
            {
                result = (new CatalogoLogic()).ListarCatFlete(sintDestinoFleteID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de instalación
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosInstalacion> ListarCatInstalacion(int intCotizacionID)
        {
            List<DatosInstalacion> result = new List<DatosInstalacion>();
            try
            {
                result = (new CatalogoLogic()).ListarCatInstalacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el tipo de unidad flete
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoUnidadFlete()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoUnidadFlete();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el catálogo de monedas
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatMoneda()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatMoneda();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        #endregion


        #region Unidades Medición

        /// <summary>
        /// Provee la colección de unidades de medida
        /// </summary>
        /// <returns>Unidades de medida</returns>
        /// <author>Fernando Ricardo Morán</author>
        public IEnumerable<UnidadMedicion> GetUnidadesMedicion()
            => (new CatalogoLogic()).GetUnidadesMedicion();


        #endregion

        #region Viaticos

        /// <summary>
        /// Envía un listado de los viaticos disponibles en el catálogo
        /// </summary>
        /// <returns>Colección de viaticos</returns>
        /// <author>Fernando Ricardo Morán</author>
        public IEnumerable<Viatico> GetViaticos()
            => (new CatalogoLogic()).GetViaticos();

        /// <summary>
        /// Edita un viatico
        /// </summary>
        /// <param name="viatico">Información del viático</param>
        public void EditViatico(Viatico viatico)
            => new CatalogoLogic().EditViatico(viatico);

        /// <summary>
        /// Elimina un viático
        /// </summary>
        /// <param name="viaticoId">Identificador del viático</param>
        /// <author>Fernando Ricardo Morán</author>
        public void DeleteViatico(short viaticoId)
            => new CatalogoLogic().DeleteViatico(viaticoId);






        #endregion


        #region Tornillería


        /// <summary>
        /// Obtiene la colección de tornillos
        /// </summary>
        /// <returns>Tornillos</returns>
        /// <author>Fernando Ricardo Morán</author>
        public IEnumerable<Tornillo> GetTornillos()
        => new CatalogoLogic().GetTornillos();

        /// <summary>
        /// Crea/actualiza un registro de tornillo
        /// </summary>
        /// <param name="tornillo">Instancia del tornillo</param>
        /// <author>Fernando Ricardo Morán</author>
        public void EditTornillo(Tornillo viatico)
            => new CatalogoLogic().EditTornillo(viatico);

        /// <summary>
        /// Elimina el registro de un tornillo
        /// </summary>
        /// <param name="tornilloId">Identificador del tornillo</param>
        /// <author>Fernando Ricardo Morán</author>
        public void DeleteTornillo(short tornilloId)
        => new CatalogoLogic().DeleteTornillo(tornilloId);

        #endregion

    }
}
