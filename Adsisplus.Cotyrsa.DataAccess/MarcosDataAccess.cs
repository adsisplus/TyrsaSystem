﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class MarcosDataAccess
    {
        public List<Configuracion_Marco> ConfiguraMarco(Int32 @intConfiguraMarcoID, Int32 @intElementoID, Int16 @sintTipoMarcoID, Int32 @intAlturaMarcoID, Int16 @sintFondoMarcoID, Int32 @intSKUID, Int16 @sintFactorMarcoID)
        {
            List<Configuracion_Marco> results = new List<Configuracion_Marco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ConfiguraMarco(@intConfiguraMarcoID, @intElementoID, @sintTipoMarcoID, @intAlturaMarcoID, @sintFondoMarcoID, @intSKUID, @sintFactorMarcoID)
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

        public List<RelSistemaCargaMarcoPoste> RelSistemaCargaMarcoPoste(Int16 @sintSistemaCargaMarcoID, Int32 @intSubProductoID, Int32 @intCargaPosteID, Int32 @intCargaMarcoID)
        {
            List<RelSistemaCargaMarcoPoste> results = new List<RelSistemaCargaMarcoPoste>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_RelSistemaCargaMarcoPoste(@sintSistemaCargaMarcoID, @intSubProductoID, @intCargaPosteID, @intCargaMarcoID)
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

        public List<DatosMarco> ListarDatosMarco(Int32 @intDatoMarcoID, Int32 @intCotizacionID, Int32 @intElementoID, Int16 @sintPinturaID)
        {
            List<DatosMarco> results = new List<DatosMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosMarco(@intDatoMarcoID, @intCotizacionID, @intElementoID, @sintPinturaID)
                                select new DatosMarco()
                                {
                                    intDatoMarcoID = item.intDatoMarcoID,
                                    intCotizacionID = item.intCotizacionID,
                                    vchFolio = item.vchFolio,
                                    vchElemento = item.vchElemento,
                                    vchPintura = item.vchPintura,
                                    decMedidaFondo = item.decMedidaFondo,
                                    decMedidaAlto = item.decMedidaAlto,
                                    bitDobleMonten = item.bitDobleMonten,
                                    intNumeroNivelSobreViga = item.intNumeroNivelSobreViga,
                                    decAlturaPandeo = item.decAlturaPandeo,
                                    decCapacidadxNivel = item.decCapacidadxNivel,
                                    sintCantidad = item.sintCantidad,
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

        public List<FondoMarco> ListarFondoMarco(Int32 @sintFondoMarcoID, Int32 @sintTipoMarcoID)
        {
            List<FondoMarco> results = new List<FondoMarco>();
            try
            {
                using (MarcosDataContext dc = new MarcosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarFondoMarco(@sintFondoMarcoID, @sintTipoMarcoID)
                                select new FondoMarco()
                                {
                                    sintFondoMarcoID = item.sintFondoMarcoID,
                                    vchTipoMarcoTyrsa = item.vchTipoMarcoTyrsa,
                                    vchFondoMarco = item.vchFondoMarco,
                                    decFondoMarco = item.decFondoMarco,
                                    vchParte1 = item.vchParte1,
                                    vchDescripcion1 = item.vchDescripcion1,
                                    decFactor1 = item.decFactor1,
                                    vchParte2 = item.vchParte2,
                                    vchDescripcion2 = item.vchDescripcion2,
                                    decFactor2 = item.decFactor2,
                                    vchParte3 = item.vchParte3,
                                    vchDescripcion3 = item.vchDescripcion3,
                                    decFactor3 = item.decFactor3,
                                    vchParte4 = item.vchParte4,
                                    vchDescripcion4 = item.vchDescripcion4,
                                    decFactor4 = item.decFactor4,
                                    vchParte5 = item.vchParte5,
                                    vchDescripcion5 = item.vchDescripcion5,
                                    decFactor5 = item.decFactor5,
                                    vchParte6 = item.vchParte6,
                                    vchDescripcion6 = item.vchDescripcion6,
                                    decFactor6 = item.decFactor6,
                                    vchParte7 = item.vchParte7,
                                    vchDescripcion7 = item.vchDescripcion7,
                                    decFactor7 = item.decFactor7,
                                    vchParte8 = item.vchParte8,
                                    vchDescripcion8 = item.vchDescripcion8,
                                    decFactor8 = item.decFactor8,
                                    vchParte9 = item.vchParte9,
                                    vchDescripcion9 = item.vchDescripcion9,
                                    decFactor9 = item.decFactor9,
                                    vchParte10 = item.vchParte10,
                                    vchDescripcion10 = item.vchDescripcion10,
                                    decFactor10 = item.decFactor10,
                                    vchParte11 = item.vchParte11,
                                    vchDescripcion11 = item.vchDescripcion11,
                                    decFactor11 = item.decFactor11,
                                    vchParte12 = item.vchParte12,
                                    vchDescripcion12 = item.vchDescripcion12,
                                    decFactor12 = item.decFactor12,
                                    vchParte13 = item.vchParte13,
                                    vchDescripcion13 = item.vchDescripcion13,
                                    decFactor13 = item.decFactor13,
                                    vchParte14 = item.vchParte14,
                                    vchDescripcion14 = item.vchDescripcion14,
                                    decFactor14 = item.decFactor14,
                                    vchParte15 = item.vchParte15,
                                    vchDescripcion15 = item.vchDescripcion15,
                                    decFactor15 = item.decFactor15,
                                    vchParte16 = item.vchParte16,
                                    vchDescripcion16 = item.vchDescripcion16,
                                    decFactor16 = item.decFactor16,
                                    vchParte17 = item.vchParte17,
                                    vchDescripcion17 = item.vchDescripcion17,
                                    decFactor17 = item.decFactor17,
                                    vchParte18 = item.vchParte18,
                                    vchDescripcion18 = item.vchDescripcion18,
                                    decFactor18 = item.decFactor18,
                                    vchParte19 = item.vchParte19,
                                    vchDescripcion19 = item.vchDescripcion19,
                                    decFactor19 = item.decFactor19,
                                    vchParaCostoLamina = item.vchParaCostoLamina,
                                    vchCostoLamina = item.vchCostoLamina,
                                    decCostoLamina = item.decCostoLamina,
                                    vchParaCostoSolera = item.vchParaCostoSolera,
                                    vchCostoSolera = item.vchCostoSolera,
                                    decCostoSolera = item.decCostoSolera,
                                    vchParaFactorAcero = item.vchParaFactorAcero,
                                    vchFactorAcero = item.vchFactorAcero,
                                    decFactorAcero = item.decFactorAcero,

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
    }
}
