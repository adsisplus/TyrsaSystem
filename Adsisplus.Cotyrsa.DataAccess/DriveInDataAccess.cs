﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class DriveInDataAccess
    {
        #region SISTEMA DRIVE IN
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de los datos Drive In
        /// </summary>
        /// <param name="driveIn"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDriveIn(DatosDriveIn driveIn, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosDriveIn(driveIn.intDatosDriveInID, driveIn.intDetCotizaID, driveIn.sintPinturaID, driveIn.intElementoID,
                        driveIn.bitEsEstructural, driveIn.bitDobleMonten, driveIn.decFrente, driveIn.decFondo, driveIn.decAltura, driveIn.decPeso,
                        driveIn.decAnchoMonta, driveIn.decAlturaMaxima, driveIn.decAlturaCanastilla, driveIn.decCapacidadMaxima, 
                        driveIn.sintMaterialDriveInID, driveIn.decAlturaDobleMonten, driveIn.bitActivo, (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, modificación o baja de los datos Atirantado
        /// </summary>
        /// <param name="atirantado"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAtirantado(DatosAtirantado atirantado, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosAtirantado(atirantado.intAtirantadoID, atirantado.intElementoID, atirantado.intCotizacionID, atirantado.sintPinturaID,
                        atirantado.intCantidad, atirantado.bitActivo, atirantado.intDetCotizaID, atirantado.decLargo, atirantado.seleccion.decPrecioVentaUnitario,
                        atirantado.seleccion.decPrecioVentaTotal, atirantado.seleccion.decPesoUnitario, atirantado.seleccion.decPesoTotal, atirantado.decLongitud, atirantado.intCalibreID,
                        atirantado.seleccion.intSeleccionArriestradoID, atirantado.seleccion.sintDriveInID, atirantado.seleccion.decAncho, atirantado.seleccion.decTotalKiloUnitario, atirantado.seleccion.decPrecioFinal,
                        (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, baja y modificación de los datos Viga Atirantado
        /// </summary>
        /// <param name="vigaAti"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosVigaAtirantado(DatosVigaAtirantado vigaAti, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosVigaAtirantado(vigaAti.intVigaAtirantadoID, vigaAti.intElementoID, vigaAti.intCotizacionID, vigaAti.sintPinturaID,
                        vigaAti.intCantidad, vigaAti.bitActivo, vigaAti.intDetCotizaID, vigaAti.decLargo, vigaAti.decPrecioVentaUnitario,
                        vigaAti.decPrecioVentaTotal, vigaAti.decPesoUnitario, vigaAti.decPesoTotal, vigaAti.decLongitud, vigaAti.intCalibreID,
                        (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, modificación y baja de los datos Brazo
        /// </summary>
        /// <param name="brazo"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBrazo(DatosBrazo brazo, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosBrazo(brazo.intBrazoID, brazo.intElementoID, brazo.intCotizacionID, brazo.sintPinturaID, brazo.intCantidad,
                        brazo.bitActivo, brazo.sintLargoBrazoID, brazo.intDetCotizaID, brazo.decLargo, brazo.seleccion.decPrecioVentaUnitario,
                        brazo.seleccion.decPrecioVentaTotal, brazo.seleccion.decPesoUnitario, brazo.seleccion.decPesoTotal, brazo.seleccion.intSeleccionBrazoID,brazo.seleccion.sintDriveInID,
                        brazo.seleccion.decLongitud, brazo.seleccion.decAncho, brazo.seleccion.decTotalKiloUnitario, brazo.seleccion.decPrecioFinal, (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, modificación y baja de los datos Riel Tarima
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRielTarima(DatosRielTarima riel, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosRielTarima(riel.intRielTarimaID, riel.intElementoID, riel.intCotizacionID, riel.intDetCotizaID,
                        riel.sintTipoRielTarimaID, riel.sintPinturaID, riel.intCantidad, riel.decCarga, riel.decLargo, riel.bitActivo, 
                        riel.seleccion.intSeleccionRielCargaID, riel.seleccion.sintDriveInID, riel.seleccion.decLongitud, riel.seleccion.decAncho, riel.seleccion.decTotalKiloUnitario,
                        riel.seleccion.decPrecioFinal, (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, modificación y baja de los datos guia entrada
        /// </summary>
        /// <param name="guia"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosGuiaEntrado(DatosGuiaEntrada guia, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosGuiaEntrada(guia.intGuiaEntradaID, guia.intElementoID, guia.intCotizacionID, guia.sintPinturaID,
                        guia.decLargo, guia.intCantidad, guia.bitActivo, guia.intDetCotizaID, guia.decPrecioUnitario,
                        guia.decPrecioTotal, guia.seleccion.intSeleccionGuiaMontaCargaID, guia.seleccion.decTotal, guia.seleccion.decTotalKiloUnitario,
                        guia.seleccion.vchMedida, guia.seleccion.decPrecioFinal, guia.seleccion.decPrecioMasLargoTotal,
                        (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, modificación y baja de los datos piso
        /// </summary>
        /// <param name="piso"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPiso(DatosPiso piso, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosPiso(piso.intDatoPisoID, piso.intElementoID, piso.intCotizacionID, piso.sintPinturaID,
                    piso.intCantidad, piso.decLargoPiso, piso.bitUsoPatin, piso.bitActivo, piso.intDetCotizaID, piso.decAncho,
                    piso.bitTipoPisoAbierto, piso.decPesoUnitario, piso.decPesoTotal, piso.decPrecioUnitario,
                    piso.decPrecioTotal, (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, baja y modificación de los datos barandal
        /// </summary>
        /// <param name="barandal"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBarandal(DatosBarandal barandal, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosBarandal(barandal.intDatosBarandalID, barandal.intElementoID, barandal.intCotizacionID, barandal.intDetCotizaID,
                        barandal.sintPinturaID, barandal.decLargo, barandal.decCantidad, barandal.decPrecioUnitario, barandal.decPrecioTotal,
                        barandal.bitActivo, (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, baja y modificación de los datos poste
        /// </summary>
        /// <param name="poste"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPosteDriveIn(DatosPosteDriveIn poste, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosPosteDriveIn(poste.intDatoPosteDriveInID, poste.intElementoID, poste.intDetCotizaID, poste.intSKUID,
                        poste.intCantidad, poste.decCalibre, poste.decSolera, poste.decTotalKilo, poste.decPrecioTyrsa,
                        poste.decRelacionPrecios, poste.decPrecioTyrsaMetro, poste.decPrecioTyrsaKg, poste.sintNumPosteReq,
                        poste.sintNumTravesanio, poste.bitActivo, (byte)tinOpcion)
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
        #endregion
        /// <summary>
        /// Procedimiento que lista los datos Drive In
        /// </summary>
        /// <param name="intDatosDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosDriveIn> ListarDatosDriveIn(int intDatosDriveInID, int intCotizacionID)
        {
            List<DatosDriveIn> result = new List<DatosDriveIn>();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosDriveIn(intDatosDriveInID, intCotizacionID)
                                select new DatosDriveIn
                                {
                                    intDatosDriveInID = item.intDatosDriveInID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    sintPinturaID = item.sintPinturaID,
                                    intElementoID = item.intElementoID,
                                    bitEsEstructural = item.bitEsEstructural,
                                    bitDobleMonten = item.bitDobleMonten,
                                    decFrente = item.decFrente,
                                    decFondo = item.decFondo,
                                    decAltura = item.decAltura,
                                    decPeso = item.decPeso,
                                    decAnchoMonta = item.decAnchoMonta,
                                    decAlturaMaxima = item.decAlturaMaxima,
                                    decAlturaCanastilla = item.decAlturaCanastilla,
                                    decCapacidadMaxima = item.decCapacidadMaxima,
                                    decAlturaDobleMonten = item.decAlturaDobleMonten,
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
        /// Procedimiento que lista los datos Drive In en base al tipo de viga
        /// </summary>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="sintLongitudID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        public List<DriveIn> ListarDatosMstDriveIn(short sintTipoVigaID, short sintLongitudID, int intCalibreID, short sintLargoID)
        {
            List<DriveIn> result = new List<DriveIn>();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarMstDiveIn(sintTipoVigaID, sintLongitudID, intCalibreID, sintLargoID)
                                select new DriveIn
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