using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class SistemasTyrsaDataAccess
    {
        public List<RelSistemaSelectivo> ListarRelSistemaSelectivo(Int32 intCotizacionID, Int32 intTipoElementoCoti_Producto, Int32 intTipoElementoID, Int32 intTipoElementoAlmacenID, Int32 intConfiguraMarcoID, Int32 intConfiguraVigaID, Int32 intDatoMarcoID, Int32 intDatosVigaID, Int32 intDatosPanelID, Int32 intDatosCrossBarID, Int32 intDistanciadorID, Int32 intParrillaID, Int32 intVigaTopeID, Int32 intProtectorPosteID, Int32 intProtectorBateriaID, Int16 sintSistemaCargaMarcoID, DateTime datFechaAlta)
        {
            List<RelSistemaSelectivo> results = new List<RelSistemaSelectivo>();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarRelSistemaSelectivo(intCotizacionID, intTipoElementoCoti_Producto, intTipoElementoID, intTipoElementoAlmacenID, intConfiguraMarcoID, intConfiguraVigaID, intDatoMarcoID, intDatosVigaID, intDatosPanelID, intDatosCrossBarID, intDistanciadorID, intParrillaID, intVigaTopeID, intProtectorPosteID, intProtectorBateriaID, sintSistemaCargaMarcoID, datFechaAlta)
                                select new RelSistemaSelectivo()
                                {
                                    intTipoElementoCoti_Producto = item.intTipoElementoCoti_Producto,
                                    intCotizacionID = item.intCotizacionID,
                                    vchDescElementoCotizar = item.vchDescElementoCotizar,
                                    vchProductoAcero = item.vchProductoAcero,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    vchConfiguraViga = item.vchConfiguraViga,
                                    intCantidadMarco = item.intCantidadMarco,
                                    intCantidadViga = item.intCantidadViga,
                                    intCantidadPanel = item.intCantidadPanel,
                                    intCantidadNivelCrossbar = item.intCantidadNivelCrossbar,
                                    intCantidadDistanciador = item.intCantidadDistanciador,
                                    decCostoParrilla = item.decCostoParrilla,
                                    intCantidadVigaTope = item.intCantidadVigaTope,
                                    intCantidadProctorPoste = item.intCantidadProctorPoste,
                                    intCantidadSencillaProtectorBateria = item.intCantidadSencillaProtectorBateria,
                                    intCantidadDobleProtectorBateria = item.intCantidadDobleProtectorBateria,
                                    intCantidadCuadrupleProtectorBateria = item.intCantidadCuadrupleProtectorBateria,
                                    vchFondoTyrsaMarco = item.vchFondoTyrsaMarco,
                                    vchFrenteTyrsaMarco = item.vchFrenteTyrsaMarco,
                                    intCapacidadPesoMarco = item.intCapacidadPesoMarco,
                                    vchFondoTyrsaPoste = item.vchFondoTyrsaPoste,
                                    vchFrenteTyrsaPoste = item.vchFrenteTyrsaPoste,
                                    intCapacidadPesoPoste = item.intCapacidadPesoPoste,
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
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosMarco"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosMarco(DatosMarco datosMarco, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosMarco(datosMarco.intDatoMarcoID, datosMarco.intCotizacionID, datosMarco.intElementoID, datosMarco.sintPinturaID,
                        datosMarco.decMedidaFondo, datosMarco.decMedidaAlto, datosMarco.bitDobleMonten, datosMarco.intNumeroNivelSobreViga, datosMarco.decAlturaPandeo,
                        datosMarco.decCapacidadxNivel, datosMarco.sintCantidad, datosMarco.bitActivo, (byte)sintOpcion)
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
        /// Realiza el alta, modificación o baja a los datos Viga
        /// </summary>
        /// <param name="datosViga"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViga(DatosViga datosViga, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosViga(datosViga.intDatosVigaID, datosViga.sintPinturaID, datosViga.intElementoID, datosViga.intDatoMarcoID,
                        datosViga.decLargo, datosViga.intCantidad, datosViga.bitActivo, (byte)sintOpcion)
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
        /// Realiza el alta, modificación o baja a los datos panel
        /// </summary>
        /// <param name="datosPanel"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPanel(DatosPanel datosPanel, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosPanel(datosPanel.intDatosPanelID, datosPanel.intElementoID, datosPanel.intDatoMarcoID, datosPanel.sintPinturaID,
                        datosPanel.decAnchoPanel, datosPanel.intCantidadPanel, datosPanel.decCapacidadCargaPanel, datosPanel.bitActivo, (byte)sintOpcion)
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
        /// Realiza el alta, modificación o baja a los datos de Cross Bar
        /// </summary>
        /// <param name="datosCrossBar"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosCrossBar(DatosCrossBar datosCrossBar, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosCrossBar(datosCrossBar.intDatosCrossBarID, datosCrossBar.intElementoID, datosCrossBar.intDatoMarcoID,
                        datosCrossBar.decAnchoCrossBar, datosCrossBar.bitConectorVigaCrossbar, datosCrossBar.intCantidadNivelCrossbar, datosCrossBar.bitActivo,
                        (byte)sintOpcion)
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
        /// Realiza el alta, modificación o baja a los datos de distanciador
        /// </summary>
        /// <param name="datosDistanciador"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDistanciador(DatosDistanciador datosDistanciador, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosDistanciador(datosDistanciador.intDistanciadorID, datosDistanciador.intCotizacionID, datosDistanciador.intElementoID,
                        datosDistanciador.intCantidadDistanciador, datosDistanciador.decLargoDistanciador, datosDistanciador.bitActivo, (byte)sintOpcion)
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
        /// Realiza el alta, baja o modificación a los datos de Parrilla
        /// </summary>
        /// <param name="datosParrilla"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosParrilla(DatosParrilla datosParrilla, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosParrilla(datosParrilla.intParrillaID, datosParrilla.intElementoID, datosParrilla.sintPinturaID,
                        datosParrilla.intCotizacionID, datosParrilla.decFrenteParrilla, datosParrilla.decFondoParrilla, datosParrilla.decCostoParrilla,
                        datosParrilla.decTamanioCuadroParrilla, datosParrilla.intCantidadParrilla, datosParrilla.bitActivo, (byte)sintOpcion)
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
        /// Realiza el alta, baja o modificación a los datos de Viga tope
        /// </summary>
        /// <param name="datosVigaTope"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosVigaTope(DatosVigaTope datosVigaTope, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosVigaTope(datosVigaTope.intVigaTopeID, datosVigaTope.intCantidadVigaTope, datosVigaTope.intElementoID,
                        datosVigaTope.intDatosVigaID, datosVigaTope.intCotizacionID, datosVigaTope.sintPinturaID, datosVigaTope.intCantidad,
                        datosVigaTope.bitActivo, (byte)sintOpcion)
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
        /// Realiza el alta, modificación o baja a los datos protector poste
        /// </summary>
        /// <param name="datosProtector"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorPoste(DatosProtectorBase datosProtector, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosProtectorPoste(datosProtector.intProtectorPosteID, datosProtector.intElementoID, datosProtector.intCotizacionID,
                        datosProtector.sintPinturaID, datosProtector.intCantidadProtectorPoste, datosProtector.bitActivo, (byte)sintOpcion)
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
        /// Realiza el alta, baja o modificación a los datos de Protector Batería
        /// </summary>
        /// <param name="datosProtectorBateria"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosProtectorBateria(DatosProtectorBateria datosProtectorBateria, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (SistemasTyrsaDataContext dc = new SistemasTyrsaDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosProtectorBateria(datosProtectorBateria.intProtectorBateriaID, datosProtectorBateria.intElementoID,
                        datosProtectorBateria.intCotizacionID, datosProtectorBateria.intCantidadSencilla, datosProtectorBateria.intCantidadDoble,
                        datosProtectorBateria.intCantidadCuadruple, datosProtectorBateria.bitActivo, (byte)sintOpcion)
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
