using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;


namespace Adsisplus.Cotyrsa.DataAccess
{
  public  class ProtectoresDataAccess
    {
        /// <summary>
        /// Procedimiento que muestra los datos del protector viga en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosProtectorBase> ListarDatosProtectorPoste(Int32 intCotizacionID)
        {
            List<DatosProtectorBase> results = new List<DatosProtectorBase>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosProtectorPoste(intCotizacionID)
                                select new DatosProtectorBase()
                                {
                                    intProtectorPosteID = item.intProtectorPosteID,
                                    vchElemento = item.vchElemento,
                                    intCotizacionID = item.intCotizacionID,
                                    vchFolio = item.vchFolio,
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    intCantidadProtectorPoste = item.intCantidadProtectorPoste,
                                    intDetCotizaID = item.intDetCotizaID,
                                    decAltura = item.decAltura,
                                    sintLongitudID = item.sintLongitudID,
                                    vchLongitud = item.vchLongitud,

                                    decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    decPrecioVentaUnitario = item.decPrecioVentaUnitario,

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
        /// Procedimeinto que nos muestra la información del protector de batería en base a la cotización
        /// </summary>
        /// <param name="intProtectorBateriaID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosProtectorBateria> ListarDatosProtectorBateria(int intCotizacionID)
        {
            List<DatosProtectorBateria> results = new List<DatosProtectorBateria>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosProtectorBateria(intCotizacionID)
                                select new DatosProtectorBateria()
                                {
                                    intProtectorBateriaID = item.intProtectorBateriaID,
                                    vchElemento = item.vchElemento,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    vchFolio = item.vchFolio,
                                    intCantidadSencilla = item.intCantidadSencilla,
                                    intCantidadDoble = item.intCantidadDoble,
                                    //intCantidadTriple = item.intCantidadTriple,
                                    intCantidadCuadruple = item.intCantidadCuadruple,
                                    decPrecioSencilla = item.decPrecioSencilla,
                                    decPrecioDoble = item.decPrecioDoble,
                                    //decPrecioTriple = item.decPrecioTriple,
                                    decPrecioCuadruple = item.decPrecioCuadruple,

                                    decLargoSencilla = item.decLargoSencilla,
                                    decLargoDoble = item.decLargoDoble,
                                    decLargoCuadruple = item.decLargoCuadruple,

                                    decPrecioVentaUnitarioSencilla = item.decPrecioVentaUnitarioSencilla,
                                    decPrecioVentaUnitarioDoble = item.decPrecioVentaUnitarioDoble,
                                    decPrecioVentaUnitarioCuadruple = item.decPrecioVentaUnitarioCuadruple,
                                    decPrecioVentaTotalSencilla = item.decPrecioVentaTotaloSencilla,
                                    decPrecioVentaTotalDoble = item.decPrecioVentaTotalDoble,
                                    decPrecioVentaTotalCuadruple = item.decPrecioVentaTotalCuadruple,
                                    decAlturaSencilla = item.decAlturaSencilla,
                                    decAlturaDoble = item.decAlturaDoble,
                                    decAlturaCuadruple = item.decAlturaCuadruple,
                                    sintPinturaIDSencilla = item.sintPinturaIDSencilla,
						            sintPinturaIDDoble = item.sintPinturaIDDoble,
                                    sintPinturaIDCuadruple = item.sintPinturaIDCuadruple,
						            intBotasSencilla = item.intBotasSencilla,
						            intBotasDoble = item.intBotasDoble,
                                    intBotasCuadruple = item.intBotasCuadruple,
						            intBarrasSencilla = item.intBarrasSencilla,
						            intBarrasDoble = item.intBarrasDoble,
                                    intBarrasCuadruple = item.intBarrasCuadruple,

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
        /// Procedimiento que permite obtener la lista de protectores rack
        /// </summary>
        /// <returns></returns>
        public List<DatosProtectorRack> ListarDatosSeleccionProtectorRack()
        {
            List<DatosProtectorRack> result = new List<DatosProtectorRack>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionProtectorRack()
                                select new DatosProtectorRack
                                {
                                    decPrecioFinal = item.decPrecioFinal,
                                    vchTipoProtector = item.vchTipoProtector
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
        /// Procedimiento que devuelve la lista de baterias sencillas
        /// </summary>
        /// <returns></returns>
        public List<DatosSeleccionBateria> ListarSeleccionBateriaSencilla()
        {
            List<DatosSeleccionBateria> result = new List<DatosSeleccionBateria>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionBateriaSencilla()
                                select new DatosSeleccionBateria
                                {
                                    SKU = item.SKU,
                                    intNumBotas = item.intNumBotas,
                                    intNumBarras = item.intNumBarras,
                                    vchMaterial = item.vchMaterial,
                                    TOTAL = item.TOTAL,
                                    intAltura = item.intAltura
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
        /// Procedimiento que lista los datos de batería doble
        /// </summary>
        /// <returns></returns>
        public List<DatosSeleccionBateria> ListarSeleccionBateriaDoble()
        {
            List<DatosSeleccionBateria> result = new List<DatosSeleccionBateria>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionBateriaDoble()
                                select new DatosSeleccionBateria
                                {
                                    SKU = item.SKU,
                                    intNumBotas = item.intNumBotas,
                                    intNumBarras = item.intNumBarras,
                                    vchMaterial = item.vchMaterial,
                                    TOTAL = item.TOTAL,
                                    intAltura = item.intAltura
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
        /// Procedimiento que lista los datos de batería cuadruple
        /// </summary>
        /// <returns></returns>
        public List<DatosSeleccionBateria> ListarSeleccionBateriaCuadruple()
        {
            List<DatosSeleccionBateria> result = new List<DatosSeleccionBateria>();
            try
            {
                using (ProtectoresDataContext dc = new ProtectoresDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionBateriaCuadruple()
                                select new DatosSeleccionBateria
                                {
                                    SKU = item.SKU,
                                    intNumBotas = item.intNumBotas,
                                    intNumBarras = item.intNumBarras,
                                    vchMaterial = item.vchMaterial,
                                    TOTAL = item.TOTAL,
                                    intAltura = item.intAltura
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
