using Adsisplus.Cotyrsa.BusinessEntities;
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
                        driveIn.bitActivo, (byte)tinOpcion)
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
                        atirantado.intCantidad, atirantado.bitActivo, atirantado.intDetCotizaID, atirantado.decLargo, atirantado.decPrecioVentaUnitario,
                        atirantado.decPrecioVentaTotal, atirantado.decPesoUnitario, atirantado.decPesoTotal, atirantado.decLongitud, atirantado.intCalibreID,
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
                        brazo.bitActivo, brazo.sintLargoBrazoID, brazo.intDetCotizaID, brazo.decLargo, brazo.decPrecioVentaUnitario,
                        brazo.decPrecioVentaTotal, brazo.decPesoUnitario, brazo.decPesoTotal, (byte)tinOpcion)
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
                        guia.decPrecioTotal, (byte)tinOpcion)
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
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosDriveIn> ListarDatosDriveIn(int intDatosDriveInID, int intDetCotizaID)
        {
            List<DatosDriveIn> result = new List<DatosDriveIn>();
            try
            {
                using (SistemaDriveInDataContext dc = new SistemaDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosDriveIn(intDatosDriveInID, intDetCotizaID)
                                select new DatosDriveIn
                                {
                                    intDatosDriveInID = item.intDatosDriveInID,
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
