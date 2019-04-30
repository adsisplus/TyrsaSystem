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
                                    intCantidadTriple = item.intCantidadTriple,
                                    intCantidadCuadruple = item.intCantidadCuadruple,
                                    decPrecioSencilla = item.decPrecioSencilla,
                                    decPrecioDoble = item.decPrecioDoble,
                                    decPrecioTriple = item.decPrecioTriple,
                                    decPrecioCuadruple = item.decPrecioCuadruple,

                                    decLargoSencilla = item.decLargoSencilla,
                                    decLargoDoble = item.decLargoDoble,
                                    decLargoTriple = item.decLargoTriple,

                                    decPrecioVentaUnitarioSencilla = item.decPrecioVentaUnitarioSencilla,
                                    decPrecioVentaUnitarioDoble = item.decPrecioVentaUnitarioDoble,
                                    decPrecioVentaUnitarioTriple = item.decPrecioVentaUnitarioTriple,
                                    decPrecioVentaTotaloSencilla = item.decPrecioVentaTotaloSencilla,
                                    decPrecioVentaTotalDoble = item.decPrecioVentaTotalDoble,
                                    decPrecioVentaTotalTriple = item.decPrecioVentaTotalTriple,
                                    decAlturaSencilla = item.decAlturaSencilla,
                                    decAlturaDoble = item.decAlturaDoble,
                                    decAlturaTriple = item.decAlturaTriple,
                                    sintPinturaIDSencilla = item.sintPinturaIDSencilla,
						            sintPinturaIDDoble = item.sintPinturaIDDoble,
						            sintPinturaIDTriple = item.sintPinturaIDTriple,
						            intBotasSencilla = item.intBotasSencilla,
						            intBotasDoble = item.intBotasDoble,
						            intBotasTriple = item.intBotasTriple,
						            intBarrasSencilla = item.intBarrasSencilla,
						            intBarrasDoble = item.intBarrasDoble,
						            intBarrasTriple = item.intBarrasTriple,

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
