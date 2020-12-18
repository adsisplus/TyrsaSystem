using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessEntities.Catalogos;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CatalogoLogic
    {
        #region Constructor

        private readonly CatalogosDataAccess CatalogosDA;

        public CatalogoLogic()
        {
            CatalogosDA = new CatalogosDataAccess();

        }

        #endregion

        #region Obtiene los datos de Catalogos de personas, direcciones y cotizaciones generales

        public List<Localidad> ListarCatLocalidad(Int32 int_MunicipioID)
        {
            List<Localidad> results = null;
            try
            {
                results = CatalogosDA.ListarCatLocalidad(int_MunicipioID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatEstado()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatEstado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }


        public List<Municipio> ListarCatMunicipio(Int32 intEstadoID)
        {
            List<Municipio> results = null;
            try
            {
                results = CatalogosDA.ListarCatMunicipio(intEstadoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatPersonalidad()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatPersonalidad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatPrioridad()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatPrioridad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }


        public List<Catalogo> ListarCatTipoDomicilio()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoDomicilio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoEmpresa()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoEmpresa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoPersona()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoPersona();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        #endregion

        #region Obtiene los datos de Catalogos de Sistemas a cotizar

        public List<CatalogoDecimal> ListarCatAlturaMarco()
        {
            List<CatalogoDecimal> results = null;
            try
            {
                results = CatalogosDA.ListarCatAlturaMarco();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatCalibreAcero()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatCalibreAcero();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatCalibreViga()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatCalibreViga();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<CapacidadViga> ListarCatCapacidadViga(Int16 sintTipoVigaID, Int16 sintLongitudID, Int32 intCalibreID, Int16 sintLargoID)
        {
            List<CapacidadViga> results = null;
            try
            {
                results = CatalogosDA.ListarCatCapacidadViga(sintTipoVigaID, sintLongitudID, intCalibreID, sintLargoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<ComplementoObligatorio> ListarCatComplementoObligatorio(Int32 intElementoID)
        {
            List<ComplementoObligatorio> results = null;
            try
            {
                results = CatalogosDA.ListarCatComplementoObligatorio(intElementoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Elemento> ListarCatElemento(Int32 intSubProductoID)
        {
            List<Elemento> results = null;
            try
            {
                results = CatalogosDA.ListarCatElemento(intSubProductoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatEstatus()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatEstatus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<FactorMarco> ListarCatFactorMarco()
        {
            List<FactorMarco> results = null;
            try
            {
                results = CatalogosDA.ListarCatFactorMarco();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatInsumoViga()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatInsumoViga();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Lista los factores de la viga en base al calibre y a la familia de la viga
        /// </summary>
        /// <returns></returns>
        public List<FactorViga> ListarCatFactorViga(int intCalibreID, short sintFamiliaVigaID)
        {
            List<FactorViga> results = null;
            try
            {
                results = CatalogosDA.ListarCatFactorViga(intCalibreID, sintFamiliaVigaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<CatalogoEntero> ListarCatLargoViga()
        {
            List<CatalogoEntero> results = null;
            try
            {
                results = CatalogosDA.ListarCatLargoViga();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Modelo> ListarCatModelo(Int32 intElementoID)
        {
            List<Modelo> results = null;
            try
            {
                results = CatalogosDA.ListarCatModelo(intElementoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatMontaje()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatMontaje();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatNumeroCarro()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatNumeroCarro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatPeralte()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatPeralte();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Pintura> ListarCatPintura()
        {
            List<Pintura> results = null;
            try
            {
                results = CatalogosDA.ListarCatPintura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatProductoGeneral()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatProductoGeneral();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatRielTarima()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatRielTarima();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<CatalogoEntero> ListarCatSKU()
        {
            List<CatalogoEntero> results = null;
            try
            {
                results = CatalogosDA.ListarCatSKU();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<SubFamiliaMarco> ListarCatSubfamiliaMarco(Int16 sintFondoMarcoID, Int16 sintTipoMarcoID)
        {
            List<SubFamiliaMarco> results = null;
            try
            {
                results = CatalogosDA.ListarCatSubfamiliaMarco(sintFondoMarcoID, sintTipoMarcoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Subproducto> ListarCatSubproducto(Int32 intProductoGralID)
        {
            List<Subproducto> results = null;
            try
            {
                results = CatalogosDA.ListarCatSubproducto(intProductoGralID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoAnguloRanurado()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoAnguloRanurado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoEntrepanio()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoEntrepanio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoGalvanizado()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoGalvanizado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<TipoMarco> ListarCatTipoMarco(Int16 sintSeccionPosteID)
        {
            List<TipoMarco> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoMarco(sintSeccionPosteID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoMaterialMarco()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoMaterialMarco();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoPerfil()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoPerfil();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<TipoProtector> ListarCatTipoProtector(Int32 intTipoElementoAlmacenID)
        {
            List<TipoProtector> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoProtector(intTipoElementoAlmacenID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatTipoViga()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatTipoViga();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatUnidadMedicion()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatUnidadMedicion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<Catalogo> ListarCatSeccionPosteMarco()
        {
            List<Catalogo> results = null;
            try
            {
                results = CatalogosDA.ListarCatSeccionPosteMarco();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<CargaMarco> ListarCatCargaMarco(Int32 intCargaMarcoID, Int16 sintTipoMarcoID, Int32 intCalibreAceroID)
        {
            List<CargaMarco> results = null;
            try
            {
                results = CatalogosDA.ListarCatCargaMarco(intCargaMarcoID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<CargaPoste> ListarCatCargaPoste(Int32 intCargaPosteID, Int16 sintTipoMarcoID, Int32 intCalibreAceroID)
        {
            List<CargaPoste> results = null;
            try
            {
                results = CatalogosDA.ListarCatCargaPoste(intCargaPosteID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<ProductoAcero> ListarCatProductoAcero(Int32 intTipoElementoAlmacenID, Int32 intUnidadMedicionID, Int32 intCalibreAceroID)
        {
            List<ProductoAcero> results = null;
            try
            {
                results = CatalogosDA.ListarCatProductoAcero(intTipoElementoAlmacenID, intUnidadMedicionID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        /// <summary>
        /// Obtiene la lista de familias de vigas activas
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatFamiliaViga()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CatalogosDA.ListarCatFamiliaViga();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Obtenemos el catálogo de factores de cotización en base a la clave del factor
        /// </summary>
        /// <param name="sintFactorID"></param>
        /// <returns></returns>
        public List<FactorCotizacion> ListarCatFactorCotizacion(short sintFactorID)
        {
            List<FactorCotizacion> result = new List<FactorCotizacion>();
            try
            {
                result = CatalogosDA.ListarCatFactorCotizacion(sintFactorID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de categorias
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatCategoria()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CatalogosDA.ListarCatCategoria();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Devuelve la lista de sistemas en base al producto general
        /// </summary>
        /// <param name="intProductoGralID"></param>
        /// <returns></returns>
        public List<Catalogo> ListarCatSistema(int intProductoGralID)
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CatalogosDA.ListarCatSistema(intProductoGralID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion

        /// <summary>
        /// Procedimiento que lista los datos del insumo individual
        /// <paramref name="intSubProductoID"/>
        /// </summary>
        /// <returns></returns>
        public List<InsumoIndividual> ListarCatInsumoIndividual(int intSubProductoID)
        {
            List<InsumoIndividual> result = new List<InsumoIndividual>();
            try
            {
                result = CatalogosDA.ListarCatInsumoIndividual(intSubProductoID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarViatico();
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarCatDestinoFlete();
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarCatFlete(sintDestinoFleteID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarCatInstalacion(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento de alta, baja y modificación de los datos del insumo individual
        /// </summary>
        /// <param name="insumo"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosInsumoIndividual(InsumoIndividual insumo, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setDatosInsumoIndividual(insumo, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el valor de altura de pandeo
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatAlturaPandeoMarco()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = CatalogosDA.ListarCatAlturaPandeoMarco();
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarCatTipoUnidadFlete();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el catálogo de calibres
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibre()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CatalogosDA.ListarCatCalibre();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el catálogo de largo de crossbar
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatLargoCrossBar()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = CatalogosDA.ListarCatLargoCrossBar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el catálogo de largo de Brazo
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatLargoBrazo()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = CatalogosDA.ListarCatLargoBrazo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el catálogo de material DriveIn
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatMaterialDriveIn()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CatalogosDA.ListarCatMaterialDriveIn();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos del catálogo de Tipo Piso
        /// </summary>
        /// <param name="decLargo"></param>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoPiso(decimal decLargo)
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CatalogosDA.ListarCatTipoPiso(decLargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el largo del angulo
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatLargoAngulo()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = CatalogosDA.ListarCatLargoAngulo();
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarCatMoneda();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        #region Viaticos

        public IEnumerable<Viatico> GetViaticos()
            =>  CatalogosDA.GetViaticos();

        


        #endregion

    }
}
