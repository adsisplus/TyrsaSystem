using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class MarcosDataAccess
    {
        public List<Configuracion_Marco> ConfiguraMarco(Int32 intConfiguraMarcoID, Int32 intElementoID, Int16 sintTipoMarcoID, Int32 intAlturaMarcoID, 
            Int16 sintFondoMarcoID, Int32 intSKUID, Int16 sintFactorMarcoID, decimal decFondoMarco)
        {
            List<Configuracion_Marco> results = new List<Configuracion_Marco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ConfiguraMarco(intConfiguraMarcoID, intElementoID, sintTipoMarcoID, intAlturaMarcoID, 
                        sintFondoMarcoID, intSKUID, sintFactorMarcoID, decFondoMarco)
                                select new Configuracion_Marco()
                                {
                                    intConfiguraMarcoID = item.intConfiguraMarcoID,
                                    vchElemento = item.vchElemento,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa,
                                    sintSKU = item.sintSKU,
                                    decAlturaMarco = item.decAlturaMarco,
                                    decFondoMarco = item.decFondoMarco,
                                    vchContanteMarco = item.vchContanteMarco,
                                    decCalibre = item.decCalibre,
                                    decSolera = item.decSolera,
                                    decTotalKilo = item.decTotalKilo,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    decRelacionPrecios = item.decRelacionPrecios,
                                    decPrecioTyrsaMetro = item.decPrecioTyrsaMetro,
                                    decPrecioTyrsaKg = item.decPrecioTyrsaKg,
                                    sintNumPosteReq = item.sintNumPosteReq,
                                    sintNumTravesanio = item.sintNumTravesanio,
                                    sintDiagonalLarga = item.sintDiagonalLarga,
                                    sintDiagonalCorta = item.sintDiagonalCorta,
                                    decPesoCobroLam14 = item.decPesoCobroLam14,
                                    decPesoTotal = item.decPesoTotal,
                                    decPintaPoste = item.decPintaPoste,
                                    decPintaTravesanio = item.decPintaTravesanio,
                                    decPintaDiagonalLarga = item.decPintaDiagonalLarga,
                                    decPintaDiagonalCorta = item.decPintaDiagonalCorta,
                                    decPintaPlacaBase = item.decPintaPlacaBase,
                                    decTotalMarcoCompleto = item.decTotalMarcoCompleto,
                                    decCalibreDosCaras = item.decCalibreDosCaras,
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

        public List<RelSistemaCargaMarcoPoste> RelSistemaCargaMarcoPoste(Int16 sintSistemaCargaMarcoID, Int32 intSubProductoID, Int32 intCargaPosteID, Int32 intCargaMarcoID)
        {
            List<RelSistemaCargaMarcoPoste> results = new List<RelSistemaCargaMarcoPoste>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_RelSistemaCargaMarcoPoste(sintSistemaCargaMarcoID, intSubProductoID, intCargaPosteID, intCargaMarcoID)
                                select new RelSistemaCargaMarcoPoste()
                                {
                                    sintSistemaCargaMarcoID = item.sintSistemaCargaMarcoID,
                                    vchDescripcionSub = item.vchDescripcionSub,
                                    vchFondoTyrsaPoste = item.vchFondoTyrsaPoste,
                                    vchFondoTyrsaMarco = item.vchFondoTyrsaMarco,
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
        /// Obtiene la listad de datos ligados al marco
        /// </summary>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosMarco> ListarDatosMarco(int intDatoMarcoID, int intCotizacionID)
        {
            List<DatosMarco> results = new List<DatosMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosMarco(intDatoMarcoID, intCotizacionID)
                                select new DatosMarco()
                                {
                                    intDatoMarcoID = item.intDatoMarcoID,
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    intElementoID = item.intElementoID,
                                    vchElemento = item.vchElemento,
                                    intConfiguraMarcoID = item.intConfiguraMarcoID,
                                    sintCantidad = item.sintCantidad,
                                    decMedidaAlto = item.decMedidaAlto,

                                    decAlturaPandeo = item.decAlturaPandeo,
                                    decAltura = item.decAltura,
                                    decFondo = item.decFondo,

                                    bitSobreViga = item.bitSobreViga,
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
        /// Procedimiento que lista el fondo de Marco
        /// </summary>
        /// <returns></returns>
        public List<FondoMarco> ListarFondoMarco()
        {
            List<FondoMarco> results = new List<FondoMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatFondoMarco()
                                select new FondoMarco()
                                {
                                    vchFondoMarco = item.vchFondoMarco,
                                    decFondoMarco = item.decFondoMarco,
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

        public List<FondoMarco> ListarFondoMarcoConfiguracion()
        {
            List<FondoMarco> result = new List<FondoMarco>();
            return result;
        }

        public Resultado ActualizaFactorMarco(Int16 sintFondoMarcoID, Decimal decCostoLamina, Decimal decCostoSolera, Decimal decFactorAcero, byte tinOpcion)
        {
            Resultado results = new Resultado();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ActualizaFactorMarco(sintFondoMarcoID, decCostoLamina, decCostoSolera, decFactorAcero, tinOpcion)
                                select new Resultado()
                                {
                                    vchResultado = item.vchResultado,
                                    vchDescripcion = item.vchDescripcion,
                                    
                                };
                    results = query.First();
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
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
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
        /// <summary>
        /// Devuelve el catálogo de la capacidad de carga para un marco
        /// </summary>
        /// <returns></returns>
        public List<CargaMarco> ListarCatCargaMarco(int intCargaMarcoID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaMarco> result = new List<CargaMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCargaMarco(intCargaMarcoID, sintTipoMarcoID, intCalibreAceroID)
                                select new CargaMarco()
                                {
                                    bitActivo = item.bitActivo,
                                    decAlturaPandeoM = item.decAlturaPandeoM,
                                    intAlturaPandeoIN = item.intAlturaPandeoIN,
                                    intCapacidadPeso = item.intCapacidadPeso,
                                    intCargaMarcoID = item.intCargaMarcoID,
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    vchFondoMercadoA = item.vchFondoMercadoA,
                                    vchFondoMercadoB = item.vchFondoMercadoB,
                                    vchFondoTyrsa = item.vchFondoTyrsa,
                                    vchFrenteMercadoA = item.vchFrenteMercadoA,
                                    vchFrenteMercadoB = item.vchFrenteMercadoB,
                                    vchFrenteTyrsa = item.vchFrenteTyrsa,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa
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
        /// Obtiene la capacidad de carga de los postes
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
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatCargaPoste(intCargaPosteID, sintTipoMarcoID, intCalibreAceroID)
                                select new CargaPoste()
                                {
                                    bitActivo = item.bitActivo,
                                    decAlturaPandeoM = item.decAlturaPandeoM,
                                    intAlturaPandeoIN = item.intAlturaPandeoIN,
                                    intCapacidadPeso = item.intCapacidadPeso,
                                    intCargaPosteID = item.intCargaPosteID,
                                    vchCalibreAcero = item.vchCalibreAcero,
                                    vchFondoMercadoA = item.vchFondoMercadoA,
                                    vchFondoMercadoB = item.vchFondoMercadoB,
                                    vchFondoTyrsa = item.vchFondoTyrsa,
                                    vchFrenteMercadoA = item.vchFrenteMercadoA,
                                    vchFrenteMercadoB = item.vchFrenteMercadoB,
                                    vchFrenteTyrsa = item.vchFrenteTyrsa,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa
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
        /// Procedimiento que permite listar los marcos en base a la capacidad
        /// de carga y la altura de pandeo
        /// </summary>
        /// <param name="decCapacidadCarga"></param>
        /// <param name="decAlturaPandeo"></param>
        /// <returns></returns>
        public List<SeleccionMarco> ListarSeleccionMarco(decimal decCapacidadCarga, decimal decAlturaPandeo, decimal decFondo, 
            decimal decAlturaMarco, short sintSistemaID, bool bitEstructural)
        {
            List<SeleccionMarco> result = new List<SeleccionMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionMarco(decCapacidadCarga, decAlturaPandeo, decFondo, decAlturaMarco, sintSistemaID, bitEstructural)
                                select new SeleccionMarco
                                {
                                    intConfiguraMarcoID = Convert.ToInt32(item.intConfiguraMarcoID),
                                    decAltura = Convert.ToDecimal(item.decAltura),
                                    decAlturaPandeo = Convert.ToDecimal(item.decAlturaPandeo),
                                    decCapacidadMarco = Convert.ToDecimal(item.decCapacidadMarco),
                                    decFondo = Convert.ToDecimal(item.decFondo),
                                    decPesoMarco = Convert.ToDecimal(item.decPesoMarco),
                                    decPrecioUnitario = Convert.ToDecimal(item.decPrecioUnitario),
                                    vchMaterial = Convert.ToString(item.vchMaterial),
                                    intMaterialID = Convert.ToInt32(item.intMaterialID),
                                    vchSKU = Convert.ToString(item.SKU),
                                    vchTipo = Convert.ToString(item.vchTipo),
                                    intTipoID = Convert.ToInt32(item.intTipoID)

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
        /// Procedimiento que obtiene los datos a mostrar en patalla del marco
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <param name="intSeleccionMarcoID"></param>
        /// <returns></returns>
        public List<DatosPantallaMarco> ListarDatosPantallaMarco(int intDetCotizacionID, int intSeleccionMarcoID)
        {
            List<DatosPantallaMarco> result = new List<DatosPantallaMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPantallaMarco(intDetCotizacionID, intSeleccionMarcoID)
                                select new DatosPantallaMarco
                                {
                                    seleccion = new SeleccionMarco()
                                    {
                                        intRackID = item.intRackID,
                                        intDetCotizaID = item.intDetCotizaID,
                                        intSeleccionMarcoID = item.intSeleccionMarcoID,
                                        intNumeroNiveles = item.intNumeroNiveles,
                                        bitEstructural = item.bitEstructural,
                                        bitRolado = item.bitRolado,
                                        decFondoMarco = item.decFondoMarco,
                                        decAlturaMarco = item.decAlturaMarco,
                                        decAlturaPandeoRack = item.decAlturaPandeoRack,
                                        decCapacidadCargaTotal = item.decCapacidadCargaTotal,

                                        // Datos del marco seleccionado
                                        vchSKU = item.SKU,
                                        decPesoMarco = item.decPesoMarco,
                                        decPrecioUnitario = item.decPrecioUnitario,
                                        intTipoID = item.intTipoID,
                                        intMaterialID = item.intMaterialID,
                                        decFondo = item.decFondo,
                                        decAltura = item.decAltura,
                                        decAlturaPandeo = item.decAlturaPandeo,
                                        decCapacidadMarco = item.decCapacidadMarco

                                    },
                                    marco = new DatosMarco()
                                    {
                                        intDatoMarcoID = item.intDatoMarcoID,
                                        sintPinturaID = item.sintPinturaID,
                                        sintCantidad = item.sintCantidad,
                                        decMedidaAlto = item.decMedidaAlto,
                                        decAlturaPandeo = item.decAlturaPandeo,
                                        decAltura = item.decAltura,
                                        decFondo = item.decFondo
                                    }
                                };
                    result.AddRange(query);
                }

                // Realizamos el barrido de la lista
                for (int i = 0; i < result.Count(); i++)
                    result[i].nivel = ListarDatosNivelPorMarco((int)result[i].seleccion.intSeleccionMarcoID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de nivel por marco
        /// <paramref name="intSeleccionMarcoID"/>
        /// </summary>
        /// <returns></returns>
        public List<NivelPorMarco> ListarDatosNivelPorMarco(int intSeleccionMarcoID)
        {
            List<NivelPorMarco> result = new List<NivelPorMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosNivelPorMarco(intSeleccionMarcoID)
                                select new NivelPorMarco
                                {
                                    intNivelID = item.intNivelID,
                                    intSeleccionMarcoID = item.intSeleccionMarcoID,
                                    intNumeroTarima = item.intNumeroTarima,
                                    decPeso = item.decPeso,
                                    decTotal = item.decTotal
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
        /// Procedimiento que muestra la seleccion del marco
        /// </summary>
        /// <param name="intSeleccionMarcoID"></param>
        /// <returns></returns>
        public List<SeleccionMarco> ListarDatosSeleccionMarco(int intCotizacionID)
        {
            List<SeleccionMarco> result = new List<SeleccionMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosSeleccionMarco(intCotizacionID)
                                select new SeleccionMarco
                                {
                                    intSeleccionMarcoID = item.intSeleccionMarcoID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intDatoMarcoID = item.intDatoMarcoID,

                                    vchSKU = item.SKU,
                                    intConfiguraMarcoID = item.intConfiguraMarcoID,
                                    decPesoMarco = item.decPesoMarco,
                                    decPrecioUnitario = item.decPrecioUnitario,
                                    intTipoID = item.intTipoID,
                                    vchTipo = item.vchTipo,
                                    intMaterialID = item.intMaterialID,
                                    vchMaterial = item.vchMaterialID,
                                    decFondo = item.decFondo,
                                    decAltura = item.decAltura,
                                    decAlturaPandeo = item.decAlturaPandeo,
                                    decCapacidadMarco = item.decCapacidadMarco,
                                    intCantidad = item.intCantidad,
                                    decSubtotal = item.decSubtotal,
                                    bitActivo = item.bitActivo
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
        /// Procedimiento que revisa si el marco está ligado con otros elementos de la cotización
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public bool hayElementosVinculadosAlMarco(int intDetCotizaID)
        {
            bool result = false;
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    result = (bool) dc.fn_getHayElementosVinculadosAlMarco(intDetCotizaID);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Permite actualizar los factores del marco
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public Resultado setFondoMarco(FondoMarco factor)
        {
            Resultado result = new Resultado();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    //var query = from item in dc.stp_setFondoMarco(factor.sintFondoMarcoID, factor.decFactor1, factor.decFactor2, factor.decFactor3, factor.decFactor5,
                    //    factor.decFactor7, factor.decFactor9, factor.decFactor11, factor.decFactor13, factor.decFactor15, factor.decFactor17, factor.decFactor18)
                    //            select new Resultado
                    //            {
                    //                vchDescripcion = item.vchDescripcion,
                    //                vchResultado = item.vchResultado
                    //            };
                    //result = query.First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena toda la información de la pantalla de captura de Marco
        /// </summary>
        /// <param name="marco"></param>
        /// <param name="listNivel"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionMarco(SeleccionMarco marco, List<NivelPorMarco> listNivel, short tinOpcion)
        {
            Resultado result = new Resultado();
            Resultado resultNivel = new Resultado();
            int intNumeroNivelAnterior = 0;
            int intNumeroNivelNuevo = 0;
            try
            {
                //Revisamos si existe una lista
                if (marco != null)
                {
                    //using (TransactionScope transaction = new TransactionScope())
                    //{
                    // Obtenemos el número de niveles anterior
                    intNumeroNivelAnterior = (int)(new MarcosDataContext(Helper.ConnectionString())).fn_getNumeroNivelMarco(marco.intSeleccionMarcoID);
                    using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                    {
                        var query = from item in dc.stp_setSeleccionMarco(marco.intSeleccionMarcoID, marco.intRackID, marco.intDetCotizaID, marco.intConfiguraMarcoID,
                            marco.decFondoMarco, marco.decAlturaMarco, marco.decAlturaPandeoRack, marco.vchSKU, marco.decPesoMarco,
                            marco.decPrecioUnitario, marco.intTipoID, marco.intMaterialID, marco.decFondo, marco.decAltura,
                            marco.decAlturaPandeo, marco.decCapacidadMarco, marco.bitEstructural, marco.bitRolado, marco.intNumeroNiveles,
                            marco.decCapacidadCargaTotal, marco.bitActivo, (byte)tinOpcion)
                                    select new Resultado
                                    {
                                        vchDescripcion = item.vchDescripcion,
                                        vchResultado = item.vchResultado
                                    };
                        result = query.First();
                    }
                    // Obtenemos el número de niveles nuevo
                    intNumeroNivelNuevo = (int)marco.intNumeroNiveles;
                    if (result.vchResultado != "NOK")
                    {
                        // Almacenamos los cambios para el procedimiento de nivel marco
                        // Registro Nuevo o Actualización
                        if (tinOpcion == 1 || intNumeroNivelAnterior == intNumeroNivelNuevo)
                            foreach (NivelPorMarco nivel in listNivel)
                            {
                                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                                {
                                    var query = from item in dc.stp_setNivelPorMarco(nivel.intNivelID, Convert.ToInt32(result.vchResultado), nivel.intNumeroTarima, nivel.decPeso, nivel.decTotal, nivel.bitActivo, (byte)tinOpcion)
                                                select new Resultado
                                                {
                                                    vchDescripcion = item.vchDescripcion,
                                                    vchResultado = item.vchResultado
                                                };
                                    resultNivel = query.First();
                                }
                                if (resultNivel.vchResultado == "NOK")
                                    break;
                            }
                        else
                        {
                            // Validamos si son nuevos registros
                            if (intNumeroNivelNuevo != intNumeroNivelAnterior)
                            {
                                // Recorremos la lista hasta llegar al número Nuevo
                                for (int i = 0; i < intNumeroNivelAnterior; i++)
                                {
                                    // Actualizamos los datos de la lista
                                    using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                                    {
                                        var query = from item in dc.stp_setNivelPorMarco(listNivel[i].intNivelID, Convert.ToInt32(result.vchResultado), listNivel[i].intNumeroTarima,
                                            listNivel[i].decPeso, listNivel[i].decTotal, listNivel[i].bitActivo, 2)
                                                    select new Resultado
                                                    {
                                                        vchDescripcion = item.vchDescripcion,
                                                        vchResultado = item.vchResultado
                                                    };
                                        resultNivel = query.First();
                                    }
                                    if (resultNivel.vchDescripcion == "NOK")
                                        break;
                                }
                                if (intNumeroNivelNuevo < intNumeroNivelAnterior)
                                    // Al terminar, recorremos la lista quitando hasta llegar el número de nivel anterior
                                    for (int i = intNumeroNivelNuevo; i < intNumeroNivelAnterior; i++)
                                    {
                                        // Actualizamos los datos de la lista, dando baja a los registros
                                        using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                                        {
                                            var query = from item in dc.stp_setNivelPorMarco(listNivel[i].intNivelID, Convert.ToInt32(result.vchResultado), listNivel[i].intNumeroTarima,
                                                listNivel[i].decPeso, listNivel[i].decTotal, listNivel[i].bitActivo, 3) //Quitamos los registros
                                                        select new Resultado
                                                        {
                                                            vchDescripcion = item.vchDescripcion,
                                                            vchResultado = item.vchResultado
                                                        };
                                            resultNivel = query.First();
                                        }
                                        if (resultNivel.vchDescripcion == "NOK")
                                            break;
                                    }
                                else
                                {
                                    // En caso contrario
                                    // Al terminar, recorremos la lista quitando hasta llegar el número de nivel anterior
                                    for (int i = intNumeroNivelAnterior; i < intNumeroNivelNuevo; i++)
                                    {
                                        // Actualizamos los datos de la lista, dando baja a los registros
                                        using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                                        {
                                            var query = from item in dc.stp_setNivelPorMarco(listNivel[i].intNivelID, Convert.ToInt32(result.vchResultado), listNivel[i].intNumeroTarima,
                                                listNivel[i].decPeso, listNivel[i].decTotal, listNivel[i].bitActivo, 1) // Agregamos los nuevos
                                                        select new Resultado
                                                        {
                                                            vchDescripcion = item.vchDescripcion,
                                                            vchResultado = item.vchResultado
                                                        };
                                            resultNivel = query.First();
                                        }
                                        if (resultNivel.vchDescripcion == "NOK")
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    //else
                    //{
                    //    // Para los que quedaron fuera, se establece el valor a 0

                    //}
                    // Concatenamos el resultado
                    result.vchDescripcion += ". " + resultNivel.vchDescripcion;
                    //// The Complete method commits the transaction. If an exception has been thrown,
                    //// Complete is not  called and the transaction is rolled back.
                    //if (result.vchResultado != "NOK" && resultNivel.vchResultado != "NOK")
                    //    transaction.Complete();
                    //}
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena la información de los niveles por marco
        /// </summary>
        /// <param name="nivel"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setNivelPorMarco(NivelPorMarco nivel, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setNivelPorMarco(nivel.intNivelID, nivel.intSeleccionMarcoID, nivel.intNumeroTarima, nivel.decPeso, nivel.decTotal, nivel.bitActivo, (byte)tinOpcion)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
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
        /// <summary>
        /// Procedimiento que realiza la baja lógica o física(en caso de existir un error) de los
        /// datos de Marco
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = Borrado físico de la información </br>
        ///                         0 = Borrado lógico de la información</param>
        /// <returns></returns>
        public Resultado setBajaMarco(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setBajaMarco(intDetCotizaID, bitRollBack)
                                select new Resultado
                                {
                                    vchDescripcion = item.vchDescripcion,
                                    vchResultado = item.vchResultado
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
