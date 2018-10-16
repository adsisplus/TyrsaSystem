using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class CatalogosDataAccess
    {
        public List<CatalogoDecimal> ListarCatAlturaMarco()
        {
            List<CatalogoDecimal> results = new List<CatalogoDecimal>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatAlturaMarco()
                                select new CatalogoDecimal()
                                {
                                    intCatalogoID = item.intAlturaMarcoID,
                                    decValor = item.decAlturaMarco,
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

        public List<Catalogo> ListarCatCalibreAcero()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCalibreAcero()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intCalibreAceroID,
                                    vchDescripcion = item.vchCalibreAcero,
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

        public List<Catalogo> ListarCatCalibreViga()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCalibreViga()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intCalibreID,
                                    vchDescripcion = item.vchCalibre,
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

        public List<CapacidadViga> ListarCatCapacidadViga(Int16 sintTipoVigaID, Int16 sintLongitudID, Int32 intCalibreID, Int16 sintLargoID)
        {
            List<CapacidadViga> results = new List<CapacidadViga>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCapacidadViga(sintTipoVigaID, sintLongitudID, intCalibreID, sintLargoID)
                                select new CapacidadViga()
                                {
                                    intCapacidadVigaID = item.intCapacidadVigaID,
                                    vchTipoViga = item.vchTipoViga,
                                    vchLongitud = item.vchLongitud,
                                    vchCalibre = item.vchCalibre,
                                    intLargo = item.intLargo,
                                    decCargaKg = item.decCargaKg,
                                    decCargaLbs = item.decCargaLbs,
                                    decCoeficienteSeguridad = item.decCoeficienteSeguridad,
                                    datFechaAlta = item.datFechaAlta,
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

        public List<ComplementoObligatorio> ListarCatComplementoObligatorio(Int32 intElementoID)
        {
            List<ComplementoObligatorio> results = new List<ComplementoObligatorio>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatComplementoObligatorio(intElementoID)
                                select new ComplementoObligatorio()
                                {
                                    intComplementObligatorioID = item.intComplementObligatorioID,
                                    vchElemento = item.vchElemento,
                                    datFechaAlta = item.datFechaAlta,
                                    datFechaActualizacion = item.datFechaActualizacion,
                                    intVigencia = item.intVigencia,
                                    vchDescripcionComplemento = item.vchDescripcionComplemento,
                                    intCantidad = item.intCantidad,
                                    decPrecioUnitario = item.decPrecioUnitario,
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

        public List<Elemento> ListarCatElemento(Int32 intSubProductoID)
        {
            List<Elemento> results = new List<Elemento>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatElemento(intSubProductoID)
                                select new Elemento()
                                {
                                    intElementoID = item.intElementoID,
                                    vchDescripcionSub = item.vchDescripcionSub,
                                    vchElemento = item.vchElemento,
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

        public List<Catalogo> ListarCatEstado()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatEstado()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intEstadoID,
                                    vchDescripcion = item.vchNombre
                                   
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

        public List<Catalogo> ListarCatEstatus()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatEstatus()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intEstatusID,
                                    vchDescripcion = item.vchDescripcion,
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

        public List<FactorMarco> ListarCatFactorMarco()
        {
            List<FactorMarco> results = new List<FactorMarco>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatFactorMarco()
                                select new FactorMarco()
                                {
                                    sintFactorMarcoID = item.sintFactorMarcoID,
                                    vchDescCorta = item.vchDescCorta,
                                    vchContanteMarco = item.vchContanteMarco,
                                    decCosto = item.decCosto,
                                    datFechaAlta = item.datFechaAlta,
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

        public List<Catalogo> ListarCatInsumoViga()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatInsumoViga()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintInsumoViga,
                                    vchDescripcion = item.vchInsumoViga,
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
        /// Lista los factores de la viga en base al calibre y la familia
        /// </summary>
        /// <param name="intCalibreID"></param>
        /// <param name="sintFamiliaVigaID"></param>
        /// <returns></returns>
        public List<FactorViga> ListarCatFactorViga(int intCalibreID, short sintFamiliaVigaID)
        {
            List<FactorViga> results = new List<FactorViga>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatFactorViga(intCalibreID, sintFamiliaVigaID)
                                select new FactorViga()
                                {
                                    bitActivo = (bool)item.bitActivo,
                                    decAcero = (decimal)item.decAcero,
                                    decFactorDescuento = (decimal)item.decFactorDescuento,
                                    decFactorDespiste = (decimal)item.decFactorDespiste,
                                    decFactorVenta = (decimal)item.decFactorVenta,
                                    decKgMetroCuadrado = (decimal)item.decKgMetroCuadrado,
                                    decRemache = (decimal)item.decRemache,
                                    intCalibreID = (int)item.intCalibreID,
                                    sintFactorVigaID = (short)item.sintFactorVigaID,
                                    sintFamiliaVigaID = (short)item.sintFamiliaVigaID,
                                    vchAcero = item.vchAcero,
                                    vchCalibre = item.vchCalibre,
                                    vchFactorDescuento = item.vchFactorDescuento,
                                    vchFactorDespiste = item.vchFactorDespiste,
                                    vchFactorVenta = item.vchFactorVenta,
                                    vchFamiliaViga = item.vchFamiliaViga,
                                    vchKgMetroCuadrado = item.vchKgMetroCuadrado,
                                    vchRemache = item.vchRemache
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

        public List<CatalogoEntero> ListarCatLargoViga()
        {
            List<CatalogoEntero> results = new List<CatalogoEntero>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatLargoViga()
                                select new CatalogoEntero()
                                {
                                    intCatalogoID = item.sintLargoID,
                                    intValor = item.intLargo,
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

        public List<Localidad> ListarCatLocalidad(Int32 int_MunicipioID)
        {
            List<Localidad> results = new List<Localidad>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatLocalidad(int_MunicipioID)
                                select new Localidad()
                                {
                                    intLocalidadID = item.intLocalidadID,
                                    int_MunicipioID = item.int_MunicipioID,
                                    vchNombre = item.vchNombre,
                                    intCP = item.intCP,
                                    vchZona = item.vchZona
                                    

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

        public List<Modelo> ListarCatModelo(Int32 intElementoID)
        {
            List<Modelo> results = new List<Modelo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatModelo(intElementoID)
                                select new Modelo()
                                {
                                    intModeloID = item.intModeloID,
                                    vchElemento = item.vchElemento,
                                    vchModelo = item.vchModelo,
                                    bitActivo = item.bitActivo,
                                   
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

        public List<Catalogo> ListarCatMontaje()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatMontaje()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintMontajeID,
                                    vchDescripcion = item.vchMontaje,
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

        public List<Municipio> ListarCatMunicipio(Int32 intEstadoID)
        {
            List<Municipio> results = new List<Municipio>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatMunicipio(intEstadoID)
                                select new Municipio()
                                {
                                    intMunicipioID = item.intMunicipioID,
                                    intNumero_Mpio = item.intNumero_Mpio,
                                    vchEstado = item.vchEstado,
                                    vchNombre = item.vchNombre

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

        public List<Catalogo> ListarCatNumeroCarro()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatNumeroCarro()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintNumeroCarroID,
                                    vchDescripcion = item.vchNumeroCarro,
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

        public List<Catalogo> ListarCatPeralte()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatPeralte()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintLongitudID,
                                    vchDescripcion = item.vchLongitud,
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

        public List<Catalogo> ListarCatPersonalidad()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatPersonalidad()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intPersonalidadID,
                                    vchDescripcion = item.vchPersonalidad,
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

        public List<Pintura> ListarCatPintura()
        {
            List<Pintura> results = new List<Pintura>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatPintura()
                                select new Pintura()
                                {
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    decCosto = item.decCosto,
                                    datFechaActual = item.datFechaActual,
                                    datFechaActualizacion = item.datFechaActualizacion,
                                    sintVigencia = (Int16)item.intVigencia,
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

        public List<Catalogo> ListarCatPrioridad()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatPrioridad()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintPrioridadID,
                                    vchDescripcion = item.vchPrioridad,
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

        public List<Catalogo> ListarCatProductoGeneral()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatProductoGeneral()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intProductoGralID,
                                    vchDescripcion = item.vchDescripcion,
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

        public List<Catalogo> ListarCatRielTarima()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatRielTarima()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintRielTarimaID,
                                    vchDescripcion = item.vchRielTarima,
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

        public List<CatalogoEntero> ListarCatSKU()
        {
            List<CatalogoEntero> results = new List<CatalogoEntero>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatSKU()
                                select new CatalogoEntero()
                                {
                                    intCatalogoID = item.intSKUID,
                                    intValor = item.sintSKU,
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

        public List<SubFamiliaMarco> ListarCatSubfamiliaMarco(Int16 sintFondoMarcoID, Int16 sintTipoMarcoID)
        {
            List<SubFamiliaMarco> results = new List<SubFamiliaMarco>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatSubfamiliaMarco(sintFondoMarcoID, sintTipoMarcoID)
                                select new SubFamiliaMarco()
                                {
                                    intSubfamiliaMarcoID = item.intSubfamiliaMarcoID,
                                    decFondoMarco = item.decFondoMarco,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa,
                                    vchParte = item.vchParte,
                                    vchDescripcion = item.vchDescripcion,
                                    decConDesperdicio = item.decConDesperdicio,
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

        public List<Subproducto> ListarCatSubproducto(Int32 intProductoGralID)
        {
            List<Subproducto> results = new List<Subproducto>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatSubproducto(intProductoGralID)
                                select new Subproducto()
                                {
                                    intSubProductoID = item.intSubProductoID,
                                    vchProductoGral = item.vchProductoGral,
                                    vchDescripcionSub = item.vchDescripcionSub,
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

        public List<Catalogo> ListarCatTipoAnguloRanurado()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoAnguloRanurado()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintTipoAnguloRanuradoID,
                                    vchDescripcion = item.vchTipoAnguloRanurado,
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

        public List<Catalogo> ListarCatTipoDomicilio()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoDomicilio()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intTipoDomicilioID,
                                    vchDescripcion = item.vchDescripcion,
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

        public List<Catalogo> ListarCatTipoEmpresa()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoEmpresa()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintTipoEmpresaID,
                                    vchDescripcion = item.vchTipoEmpresa,
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

        public List<Catalogo> ListarCatTipoEntrepanio()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoEntrepanio()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintTipoEntrepanioID,
                                    vchDescripcion = item.vchTipoEntrepanio,
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

        public List<Catalogo> ListarCatTipoGalvanizado()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoGalvanizado()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintTipoGalvanizadoID,
                                    vchDescripcion = item.vchTipoGalvanizado,
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

        public List<TipoMarco> ListarCatTipoMarco(Int16 sintSeccionPosteID)
        {
            List<TipoMarco> results = new List<TipoMarco>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoMarco(sintSeccionPosteID)
                                select new TipoMarco()
                                {
                                    sintTipoMarcoID = item.sintTipoMarcoID,
                                    vchSeccionPoste = item.vchSeccionPoste,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa,
                                    vchTipoMarcoMercadoA = item.vchTipoMarcoMercadoA,
                                    vchTipoMarcoMercadoB = item.vchTipoMarcoMercadoB,
                                    decPosteDesarrollo = item.decPosteDesarrollo,
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

        public List<Catalogo> ListarCatTipoMaterialMarco()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoMaterialMarco()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintTipoMaterialID,
                                    vchDescripcion = item.vchTipoMaterial,
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
        public List<Catalogo> ListarCatTipoPerfil()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoPerfil()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintTipoPerfilID,
                                    vchDescripcion = item.vchTipoPerfil,
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

        public List<Catalogo> ListarCatTipoPersona()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoPersona()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intTipoPersonaID,
                                    vchDescripcion = item.vchDescripcion,
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

        public List<TipoProtector> ListarCatTipoProtector(Int32 intTipoElementoAlmacenID)
        {
            List<TipoProtector> results = new List<TipoProtector>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoProtector(intTipoElementoAlmacenID)
                                select new TipoProtector()
                                {
                                    intTipoProtector = item.intTipoProtector,
                                    vchDescripcionTipoElemento = item.vchDescripcionTipoElemento,
                                    vchProtector = item.vchProtector,
                                    intCantidad = item.intCantidad,
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

        public List<Catalogo> ListarCatTipoViga()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatTipoViga()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintTipoVigaID,
                                    vchDescripcion = item.vchTipoViga,
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

        public List<Catalogo> ListarCatUnidadMedicion()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatUnidadMedicion()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.intUnidadMedicionID,
                                    vchDescripcion = item.vchUnidadMedicion,
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

        public List<Catalogo> ListarCatSeccionPosteMarco()
        {
            List<Catalogo> results = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatSeccionPosteMarco()
                                select new Catalogo()
                                {
                                    intCatalogoID = item.sintSeccionPosteID,
                                    vchDescripcion = item.vchSeccionPoste,
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

        public List<CargaMarco> ListarCatCargaMarco(Int32 intCargaMarcoID, Int16 sintTipoMarcoID, Int32 intCalibreAceroID)
        {
            List<CargaMarco> results = new List<CargaMarco>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCargaMarco(intCargaMarcoID, sintTipoMarcoID, intCalibreAceroID)
                                select new CargaMarco()
                                {
                                    intCargaMarcoID = item.intCargaMarcoID,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa,
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    vchFrenteTyrsa = item.vchFrenteTyrsa,
                                    vchFrenteMercadoA = item.vchFrenteMercadoA,
                                    vchFrenteMercadoB = item.vchFrenteMercadoB,
                                    vchFondoTyrsa = item.vchFondoTyrsa,
                                    vchFondoMercadoA = item.vchFondoMercadoA,
                                    vchFondoMercadoB = item.vchFondoMercadoB,
                                    decAlturaPandeoM = item.decAlturaPandeoM,
                                    intAlturaPandeoIN = item.intAlturaPandeoIN,
                                    intCapacidadPeso = item.intCapacidadPeso,
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

        public List<CargaPoste> ListarCatCargaPoste(Int32 intCargaPosteID, Int16 sintTipoMarcoID, Int32 intCalibreAceroID)
        {
            List<CargaPoste> results = new List<CargaPoste>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCargaPoste(intCargaPosteID, sintTipoMarcoID, intCalibreAceroID)
                                select new CargaPoste()
                                {
                                    intCargaPosteID = item.intCargaPosteID,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa,
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    vchFrenteTyrsa = item.vchFrenteTyrsa,
                                    vchFrenteMercadoA = item.vchFrenteMercadoA,
                                    vchFrenteMercadoB = item.vchFrenteMercadoB,
                                    vchFondoTyrsa = item.vchFondoTyrsa,
                                    vchFondoMercadoA = item.vchFondoMercadoA,
                                    vchFondoMercadoB = item.vchFondoMercadoB,
                                    decAlturaPandeoM = item.decAlturaPandeoM,
                                    intAlturaPandeoIN = item.intAlturaPandeoIN,
                                    intCapacidadPeso = item.intCapacidadPeso,
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

        public List<ProductoAcero> ListarCatProductoAcero(Int32 intTipoElementoAlmacenID, Int32 intUnidadMedicionID, Int32 intModeloID, Int32 intCalibreAceroID)
        {
            List<ProductoAcero> results = new List<ProductoAcero>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatProductoAcero(intTipoElementoAlmacenID, intUnidadMedicionID, intModeloID, intCalibreAceroID)
                                select new ProductoAcero()
                                {
                                    intTipoElementoAlmacenID = item.intTipoElementoAlmacenID,
                                    vchUnidadMedicion = item.vchUnidadMedicion,
                                    vchModelo = item.vchModelo,
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    vchDescripcionTipoElemento = item.vchDescripcionTipoElemento,
                                    decCostoNegra = item.decCostoNegra,
                                    decCostoGalvanizada = item.decCostoGalvanizada,
                                    decCapacidadAcero = item.decCapacidadAcero,
                                    decFactorNegra = item.decFactorNegra,
                                    decFactorGalvanizado = item.decFactorGalvanizado,
                                    datFechaAlta = item.datFechaAlta,
                                    datFechaActualizacion = item.datFechaActualizacion,
                                    intVigencia = item.intVigencia,
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
        /// Obtiene la lista de familias de vigas activas
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatFamiliaViga()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatFamiliaViga()
                                select new Catalogo
                                {
                                    bitActivo = item.bitActivo,
                                    intCatalogoID = item.sintFamiliaVigaID,
                                    vchDescripcion = item.vchFamiliaViga
                                };
                    result.AddRange(query);
                }
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
                using (CatalogosDataContext dc = new CatalogosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatFactorCotizacion(sintFactorID)
                                select new FactorCotizacion
                                {
                                    bitActivo = item.bitActivo,
                                    datFechaAlta = item.datFechaAlta,
                                    decFactor = item.decFactor,
                                    sintFactorID = (short)item.sintFactorID,
                                    vchFactor = item.vchFactor
                                };
                    result.AddRange(query);
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
