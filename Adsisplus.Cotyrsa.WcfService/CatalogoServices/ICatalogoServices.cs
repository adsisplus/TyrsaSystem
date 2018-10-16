using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CatalogoServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICatalogoServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICatalogoServices
    {
        /// <summary>
        /// Obtiene la lista de altura por marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatAlturaMarco")]
        List<CatalogoDecimal> ListarCatAlturaMarco();
        /// <summary>
        /// Obtiene la lista de calibre de acero
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatCalibreAcero")]
        List<Catalogo> ListarCatCalibreAcero();
        /// <summary>
        /// Obtiene la lista de calibre de la viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatCalibreViga")]
        List<Catalogo> ListarCatCalibreViga();
        /// <summary>
        /// Obtiene la lista de capacidad por viga
        /// </summary>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="sintLongitudID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatCapacidadViga")]
        List<CapacidadViga> ListarCatCapacidadViga(Int16 sintTipoVigaID, Int16 sintLongitudID, Int32 intCalibreID, Int16 sintLargoID);
        /// <summary>
        /// Obtiene la lista de complementos obligatorios
        /// </summary>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatComplementoObligatorio")]
        List<ComplementoObligatorio> ListarCatComplementoObligatorio(Int32 intElementoID);
        /// <summary>
        /// Obtiene la lista de elementos
        /// </summary>
        /// <param name="intSubProductoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatElemento")]
        List<Elemento> ListarCatElemento(Int32 intSubProductoID);
        /// <summary>
        /// Obtiene la lista de estatus
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatEstatus")]
        List<Catalogo> ListarCatEstatus();
        /// <summary>
        /// Obtiene la lista de factor por Marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatFactorMarco")]
        List<FactorMarco> ListarCatFactorMarco();
        /// <summary>
        /// Obtiene la lista de insumos por viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatInsumoViga")]
        List<Catalogo> ListarCatInsumoViga();
        /// <summary>
        /// Obtiene la lista de factor de viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatFactorViga")]
        List<FactorViga> ListarCatFactorViga(int intCalibreID, short sintFamiliaVigaID);
        /// <summary>
        /// Obtiene la lista de largo por viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatLargoViga")]
        List<CatalogoEntero> ListarCatLargoViga();
        /// <summary>
        /// Obtiene la lista de modelos
        /// </summary>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatModelo")]
        List<Modelo> ListarCatModelo(Int32 intElementoID);
        /// <summary>
        /// Obtiene la lista de montaje
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatMontaje")]
        List<Catalogo> ListarCatMontaje();
        /// <summary>
        /// Obtiene la lista de numero de carro
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatNumeroCarro")]
        List<Catalogo> ListarCatNumeroCarro();
        /// <summary>
        /// Obtiene la lista de peralte
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatPeralte")]
        List<Catalogo> ListarCatPeralte();
        /// <summary>
        /// Obtiene la lista de pinturas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatPintura")]
        List<Pintura> ListarCatPintura();
        /// <summary>
        /// Obtiene la lista de productos generales
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatProductoGeneral")]
        List<Catalogo> ListarCatProductoGeneral();
        /// <summary>
        /// Obtiene la lista de riel por tarima
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatRielTarima")]
        List<Catalogo> ListarCatRielTarima();
        /// <summary>
        /// Obtiene la lista de SKU
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatSKU")]
        List<CatalogoEntero> ListarCatSKU();
        /// <summary>
        /// Obtiene la lista de subfamilia por marco
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatSubfamiliaMarco")]
        List<SubFamiliaMarco> ListarCatSubfamiliaMarco(Int16 sintFondoMarcoID, Int16 sintTipoMarcoID);
        /// <summary>
        /// Obtiene la lista de subproducti por producto general
        /// </summary>
        /// <param name="intProductoGralID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatSubproducto")]
        List<Subproducto> ListarCatSubproducto(Int32 intProductoGralID);
        /// <summary>
        /// Obtiene la lista de tipo angulo ranurado
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoAnguloRanurado")]
        List<Catalogo> ListarCatTipoAnguloRanurado();
        /// <summary>
        /// Obtiene la lista de tipo de entrepaño
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoEntrepanio")]
        List<Catalogo> ListarCatTipoEntrepanio();
        /// <summary>
        /// Obtiene la lista de tipo de galvanizado
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoGalvanizado")]
        List<Catalogo> ListarCatTipoGalvanizado();
        /// <summary>
        /// Obtiene la lista de tipo de Marco por tipo de seccion
        /// </summary>
        /// <param name="sintSeccionPosteID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoMarco")]
        List<TipoMarco> ListarCatTipoMarco(Int16 sintSeccionPosteID);
        /// <summary>
        /// Obtiene la lista de tipo de material por marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoMaterialMarco")]
        List<Catalogo> ListarCatTipoMaterialMarco();
        /// <summary>
        /// Obtiene la lista de tipo de perfil
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoPerfil")]
        List<Catalogo> ListarCatTipoPerfil();
        /// <summary>
        /// Obtiene la lista de tipo de protector por tipo de elemento en almacen
        /// </summary>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoProtector")]
        List<TipoProtector> ListarCatTipoProtector(Int32 intTipoElementoAlmacenID);
        /// <summary>
        /// Obtiene la lista de tipo de viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatTipoViga")]
        List<Catalogo> ListarCatTipoViga();
        /// <summary>
        /// Obtiene la lista de unidad de medición
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatUnidadMedicion")]
        List<Catalogo> ListarCatUnidadMedicion();
        /// <summary>
        /// Obtiene la lista de sección poste por marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatSeccionPosteMarco")]
        List<Catalogo> ListarCatSeccionPosteMarco();
        /// <summary>
        /// Obtiene la lista de carga por marco
        /// </summary>
        /// <param name="intCargaMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatCargaMarco")]
        List<CargaMarco> ListarCatCargaMarco(Int32 intCargaMarcoID, Int16 sintTipoMarcoID, Int32 intCalibreAceroID);
        /// <summary>
        /// Obtiene la lista de cargar por poste
        /// </summary>
        /// <param name="intCargaPosteID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatCargaPoste")]
        List<CargaPoste> ListarCatCargaPoste(Int32 intCargaPosteID, Int16 sintTipoMarcoID, Int32 intCalibreAceroID);
        /// <summary>
        /// Obtiene la lista de producto por acero
        /// </summary>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="intUnidadMedicionID"></param>
        /// <param name="intModeloID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatProductoAcero")]
        List<ProductoAcero> ListarCatProductoAcero(Int32 intTipoElementoAlmacenID, Int32 intUnidadMedicionID, Int32 intModeloID, Int32 intCalibreAceroID);
        /// <summary>
        /// Obtiene la lista de familias de vigas activas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatFamiliaViga")]
        List<Catalogo> ListarCatFamiliaViga();

        /// <summary>
        /// Obtenemos el catálogo de factores de cotización en base a la clave del factor
        /// </summary>
        /// <param name="sintFactorID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListarCatFactorCotizacion")]
        List<FactorCotizacion> ListarCatFactorCotizacion(short sintFactorID);
    }
}
