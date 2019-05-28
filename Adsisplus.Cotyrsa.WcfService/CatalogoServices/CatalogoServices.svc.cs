using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CatalogoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CatalogoServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CatalogoServices.svc o CatalogoServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CatalogoServices : ICatalogoServices
    {
        /// <summary>
        /// Obtiene la lista de altura por acero
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatAlturaMarco()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = (new CatalogoLogic()).ListarCatAlturaMarco();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de calibre por acero
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibreAcero()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatCalibreAcero();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de calibre por viga
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibreViga()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatCalibreViga();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de capacidad por viga
        /// </summary>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="sintLongitudID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        public List<CapacidadViga> ListarCatCapacidadViga(short sintTipoVigaID, short sintLongitudID, int intCalibreID, short sintLargoID)
        {
            List<CapacidadViga> result = new List<CapacidadViga>();
            try
            {
                result = (new CatalogoLogic()).ListarCatCapacidadViga(sintTipoVigaID, sintLongitudID, intCalibreID, sintLargoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de carga por marco
        /// </summary>
        /// <param name="intCargaMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        public List<CargaMarco> ListarCatCargaMarco(int intCargaMarcoID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaMarco> result = new List<CargaMarco>();
            try
            {
                result = (new CatalogoLogic()).ListarCatCargaMarco(intCargaMarcoID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de carga por poste
        /// </summary>
        /// <param name="intCargaPosteID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        public List<CargaPoste> ListarCatCargaPoste(int intCargaPosteID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaPoste> result = new List<CargaPoste>();
            try
            {
                result = (new CatalogoLogic()).ListarCatCargaPoste(intCargaPosteID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de complementos obligatorios por elemento
        /// </summary>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        public List<ComplementoObligatorio> ListarCatComplementoObligatorio(int intElementoID)
        {
            List<ComplementoObligatorio> result = new List<ComplementoObligatorio>();
            try
            {
                result = (new CatalogoLogic()).ListarCatComplementoObligatorio(intElementoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de elementos por subproducto
        /// </summary>
        /// <param name="intSubProductoID"></param>
        /// <returns></returns>
        public List<Elemento> ListarCatElemento(int intSubProductoID)
        {
            List<Elemento> result = new List<Elemento>();
            try
            {
                result = (new CatalogoLogic()).ListarCatElemento(intSubProductoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de estatus
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatEstatus()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatEstatus();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de factor por marco
        /// </summary>
        /// <returns></returns>
        public List<FactorMarco> ListarCatFactorMarco()
        {
            List<FactorMarco> result = new List<FactorMarco>();
            try
            {
                result = (new CatalogoLogic()).ListarCatFactorMarco();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de factor por viga en base al calibre y a la familia de la viga
        /// </summary>
        /// <param name="intCalibreID"></param>
        /// <param name="sintFamiliaVigaID"></param>
        /// <returns></returns>
        public List<FactorViga> ListarCatFactorViga(int intCalibreID, short sintFamiliaVigaID)
        {
            List<FactorViga> result = new List<FactorViga>();
            try
            {
                result = (new CatalogoLogic()).ListarCatFactorViga(intCalibreID, sintFamiliaVigaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de insumos por viga
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatInsumoViga()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatInsumoViga();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de largo por viga
        /// </summary>
        /// <returns></returns>
        public List<CatalogoEntero> ListarCatLargoViga()
        {
            List<CatalogoEntero> result = new List<CatalogoEntero>();
            try
            {
                result = (new CatalogoLogic()).ListarCatLargoViga();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la liasta de modelos en base al elemento
        /// </summary>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        public List<Modelo> ListarCatModelo(int intElementoID)
        {
            List<Modelo> result = new List<Modelo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatModelo(intElementoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de montaje
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatMontaje()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatMontaje();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de numero de carros
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatNumeroCarro()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatNumeroCarro();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de peralte
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPeralte()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatPeralte();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de pinturas
        /// </summary>
        /// <returns></returns>
        public List<Pintura> ListarCatPintura()
        {
            List<Pintura> result = new List<Pintura>();
            try
            {
                result = (new CatalogoLogic()).ListarCatPintura();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de productos por acero
        /// </summary>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="intUnidadMedicionID"></param>
        /// <param name="intModeloID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        public List<ProductoAcero> ListarCatProductoAcero(int intTipoElementoAlmacenID, int intUnidadMedicionID, int intCalibreAceroID)
        {
            List<ProductoAcero> result = new List<ProductoAcero>();
            try
            {
                result = (new CatalogoLogic()).ListarCatProductoAcero(intTipoElementoAlmacenID, intUnidadMedicionID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de productos generales
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatProductoGeneral()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatProductoGeneral();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de riel de tarima
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatRielTarima()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatRielTarima();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de sección poste y marco
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatSeccionPosteMarco()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatSeccionPosteMarco();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista SKU
        /// </summary>
        /// <returns></returns>
        public List<CatalogoEntero> ListarCatSKU()
        {
            List<CatalogoEntero> result = new List<CatalogoEntero>();
            try
            {
                result = (new CatalogoLogic()).ListarCatSKU();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obteiene la lista de subfamilias por marco
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <returns></returns>
        public List<SubFamiliaMarco> ListarCatSubfamiliaMarco(short sintFondoMarcoID, short sintTipoMarcoID)
        {
            List<SubFamiliaMarco> result = new List<SubFamiliaMarco>();
            try
            {
                result = (new CatalogoLogic()).ListarCatSubfamiliaMarco(sintFondoMarcoID, sintTipoMarcoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de subproductos en base al producto
        /// </summary>
        /// <param name="intProductoGralID"></param>
        /// <returns></returns>
        public List<Subproducto> ListarCatSubproducto(int intProductoGralID)
        {
            List<Subproducto> result = new List<Subproducto>();
            try
            {
                result = (new CatalogoLogic()).ListarCatSubproducto(intProductoGralID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de angulo por ranuras
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoAnguloRanurado()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoAnguloRanurado();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de entrepaños
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoEntrepanio()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoEntrepanio();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de galvanizado
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoGalvanizado()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoGalvanizado();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipo de marco por sección de poste
        /// </summary>
        /// <param name="sintSeccionPosteID"></param>
        /// <returns></returns>
        public List<TipoMarco> ListarCatTipoMarco(short sintSeccionPosteID)
        {
            List<TipoMarco> result = new List<TipoMarco>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoMarco(sintSeccionPosteID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipo de material para marcos
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoMaterialMarco()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoMaterialMarco();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de perfil
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoPerfil()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoPerfil();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de proctor en base al elemento
        /// </summary>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <returns></returns>
        public List<TipoProtector> ListarCatTipoProtector(int intTipoElementoAlmacenID)
        {
            List<TipoProtector> result = new List<TipoProtector>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoProtector(intTipoElementoAlmacenID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de viga
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoViga()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoViga();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de unidades de medición
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatUnidadMedicion()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatUnidadMedicion();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
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
                result = (new CatalogoLogic()).ListarCatFamiliaViga();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new CatalogoLogic()).ListarCatFactorCotizacion(sintFactorID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new CatalogoLogic()).ListarCatCategoria();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new CatalogoLogic()).ListarCatSistema(intProductoGralID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
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
                result = (new CatalogoLogic()).ListarCatInsumoIndividual(intSubProductoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new CatalogoLogic()).setDatosInsumoIndividual(insumo, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
                result = (new CatalogoLogic()).ListarCatAlturaPandeoMarco();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
