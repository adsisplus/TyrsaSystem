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
    interface ICatalogoServices
    {
        /// <summary>
        /// Obtiene la lista de altura por marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<CatalogoDecimal> ListarCatAlturaMarco();
        /// <summary>
        /// Obtiene la lista de calibre de acero
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatCalibreAcero();
        /// <summary>
        /// Obtiene la lista de calibre de la viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
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
        List<CapacidadViga> ListarCatCapacidadViga(Int16 @sintTipoVigaID, Int16 @sintLongitudID, Int32 @intCalibreID, Int16 @sintLargoID);
        /// <summary>
        /// Obtiene la lista de complementos obligatorios
        /// </summary>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<ComplementoObligatorio> ListarCatComplementoObligatorio(Int32 @intElementoID);
        /// <summary>
        /// Obtiene la lista de elementos
        /// </summary>
        /// <param name="intSubProductoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Elemento> ListarCatElemento(Int32 @intSubProductoID);
        /// <summary>
        /// Obtiene la lista de estatus
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatEstatus();
        /// <summary>
        /// Obtiene la lista de factor por Marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<FactorMarco> ListarCatFactorMarco();
        /// <summary>
        /// Obtiene la lista de insumos por viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatInsumoViga();
        /// <summary>
        /// Obtiene la lista de factor de viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Viga> ListarCatFactorViga();
        /// <summary>
        /// Obtiene la lista de largo por viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<CatalogoEntero> ListarCatLargoViga();
        /// <summary>
        /// Obtiene la lista de modelos
        /// </summary>
        /// <param name="intElementoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Modelo> ListarCatModelo(Int32 @intElementoID);
        /// <summary>
        /// Obtiene la lista de montaje
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatMontaje();
        /// <summary>
        /// Obtiene la lista de numero de carro
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatNumeroCarro();
        /// <summary>
        /// Obtiene la lista de peralte
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatPeralte();
        /// <summary>
        /// Obtiene la lista de pinturas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Pintura> ListarCatPintura();
        /// <summary>
        /// Obtiene la lista de productos generales
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatProductoGeneral();
        /// <summary>
        /// Obtiene la lista de riel por tarima
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatRielTarima();
        /// <summary>
        /// Obtiene la lista de SKU
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<CatalogoEntero> ListarCatSKU();
        /// <summary>
        /// Obtiene la lista de subfamilia por marco
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<SubFamiliaMarco> ListarCatSubfamiliaMarco(Int16 @sintFondoMarcoID, Int16 @sintTipoMarcoID);
        /// <summary>
        /// Obtiene la lista de subproducti por producto general
        /// </summary>
        /// <param name="intProductoGralID"></param>
        /// <returns></returns>
        [OperationContract]
        List<Subproducto> ListarCatSubproducto(Int32 @intProductoGralID);
        /// <summary>
        /// Obtiene la lista de tipo angulo ranurado
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoAnguloRanurado();
        /// <summary>
        /// Obtiene la lista de tipo de entrepaño
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoEntrepanio();
        /// <summary>
        /// Obtiene la lista de tipo de galvanizado
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoGalvanizado();
        /// <summary>
        /// Obtiene la lista de tipo de Marco por tipo de seccion
        /// </summary>
        /// <param name="sintSeccionPosteID"></param>
        /// <returns></returns>
        [OperationContract]
        List<TipoMarco> ListarCatTipoMarco(Int16 @sintSeccionPosteID);
        /// <summary>
        /// Obtiene la lista de tipo de material por marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoMaterialMarco();
        /// <summary>
        /// Obtiene la lista de tipo de perfil
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoPerfil();
        /// <summary>
        /// Obtiene la lista de tipo de protector por tipo de elemento en almacen
        /// </summary>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <returns></returns>
        [OperationContract]
        List<TipoProtector> ListarCatTipoProtector(Int32 @intTipoElementoAlmacenID);
        /// <summary>
        /// Obtiene la lista de tipo de viga
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatTipoViga();
        /// <summary>
        /// Obtiene la lista de unidad de medición
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatUnidadMedicion();
        /// <summary>
        /// Obtiene la lista de sección poste por marco
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Catalogo> ListarCatSeccionPosteMarco();
        /// <summary>
        /// Obtiene la lista de carga por marco
        /// </summary>
        /// <param name="intCargaMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        [OperationContract]
        List<CargaMarco> ListarCatCargaMarco(Int32 @intCargaMarcoID, Int16 @sintTipoMarcoID, Int32 @intCalibreAceroID);
        /// <summary>
        /// Obtiene la lista de cargar por poste
        /// </summary>
        /// <param name="intCargaPosteID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        [OperationContract]
        List<CargaPoste> ListarCatCargaPoste(Int32 @intCargaPosteID, Int16 @sintTipoMarcoID, Int32 @intCalibreAceroID);
        /// <summary>
        /// Obtiene la lista de producto por acero
        /// </summary>
        /// <param name="intTipoElementoAlmacenID"></param>
        /// <param name="intUnidadMedicionID"></param>
        /// <param name="intModeloID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        [OperationContract]
        List<ProductoAcero> ListarCatProductoAcero(Int32 @intTipoElementoAlmacenID, Int32 @intUnidadMedicionID, Int32 @intModeloID, Int32 @intCalibreAceroID);

    }
}
