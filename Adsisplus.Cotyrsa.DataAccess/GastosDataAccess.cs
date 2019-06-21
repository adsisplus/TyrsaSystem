using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class GastosDataAccess
    {
        /// <summary>
        /// Procedimiento que devuelve los datos de la pantalla de Gastos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public DatosGastos ListarDatosPantallaGastos(int intCotizacionID)
        {
            DatosGastos result = new DatosGastos();
            List<DatosFlete> fletes = new List<DatosFlete>();
            List<DatosInstalacion> instalaciones = new List<DatosInstalacion>();
            List<DatosViaticos> viaticos = new List<DatosViaticos>();
            try
            {
                // Obtenemos la lista de datos de flete
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosFlete(intCotizacionID, 0)
                                select new DatosFlete
                                {
                                    intDatoFleteID = item.intDatoFleteID,
                                    sintFleteID = item.sintFleteID,
                                    sintTipoUnidadFleteID = item.sintTipoUnidadFleteID,
                                    vchTipoUnidad = item.vchTipoUnidad,
                                    sintDestinoFleteID = item.sintDestinoFleteID,
                                    vchDestinoFlete = item.vchDestinoFlete,
                                    intElementoID = item.intElementoID,
                                    intCantidad = item.intCantidad,
                                    datFechaCarga = item.datFechaCarga,
                                    datFechaDescarga = item.datFechaDescarga
                                };
                    fletes.AddRange(query);
                }
                // Obtenemos la lista de datos de instalación
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosInstalacion(intCotizacionID, 0)
                                select new DatosInstalacion
                                {
                                    intDatosInstalacionID = item.intDatosInstalacionID,
                                    sintInstalacionID = item.sintInstalacionID,
                                    vchDescripcion = item.vchDescripcion,
                                    intUnidadMedicionID = item.intUnidadMedicionID,
                                    vchUnidadMedicion = item.vchUnidadMedicion,
                                    intInstalacion = item.intInstalacion,
                                    intDesinstalacion = item.intDesinstalacion,
                                    intElementoID = item.intElementoID,
                                    intCantidad = item.intCantidad
                                };
                    instalaciones.AddRange(query);
                }
                // Obtenemos la lista de datos de viáticos
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosViatico(intCotizacionID, 0)
                                select new DatosViaticos
                                {
                                    intDatoViaticoID = item.intDatoViaticoID,
                                    sintViaticoID = item.sintViaticoID,
                                    vchDescripcion = item.vchDescripcion,
                                    intUnidadMedicionID = item.intUnidadMedicionID,
                                    vchUnidadMedicion = item.vchUnidadMedicion,
                                    intInstalacion = item.intInstalacion,
                                    decFactor = item.decFactor,
                                    intCantidad = item.intCantidad,
                                    decCostoGolpe = item.decCostoGolpe,
                                    bitTieneCosto = item.bitTieneCosto,
                                    datFecha = item.datFecha
                                };
                    viaticos.AddRange(query);
                }
                // Establecemos los datos al resultado
                result.intCotizacionID = intCotizacionID;
                result.flete = fletes;
                result.instalacion = instalaciones;
                result.viatico = viaticos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene la lista de datos instalación en base al ID de
        /// la instalación
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintInstalacionID"></param>
        /// <returns></returns>
        public List<DatosInstalacion> ListarDatosInstalacion(int intCotizacionID, short sintInstalacionID)
        {
            List<DatosInstalacion> result = new List<DatosInstalacion>();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosInstalacion(intCotizacionID, sintInstalacionID)
                                select new DatosInstalacion
                                {
                                    intDatosInstalacionID = item.intDatosInstalacionID,
                                    sintInstalacionID = item.sintInstalacionID,
                                    vchDescripcion = item.vchDescripcion,
                                    intUnidadMedicionID = item.intUnidadMedicionID,
                                    vchUnidadMedicion = item.vchUnidadMedicion,
                                    intInstalacion = item.intInstalacion,
                                    intDesinstalacion = item.intDesinstalacion,
                                    intElementoID = item.intElementoID,
                                    intCantidad = item.intCantidad
                                };
                    result.AddRange(query);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que obtiene los datos de flete
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintFleteID"></param>
        /// <returns></returns>
        public List<DatosFlete> ListarDatosFlete(int intCotizacionID, int? intDatoFleteID)
        {
            List<DatosFlete> result = new List<DatosFlete>();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosFlete(intCotizacionID, intDatoFleteID)
                                select new DatosFlete
                                {
                                    intDatoFleteID = item.intDatoFleteID,
                                    sintFleteID = item.sintFleteID,
                                    sintTipoUnidadFleteID = item.sintTipoUnidadFleteID,
                                    vchTipoUnidad = item.vchTipoUnidad,
                                    sintDestinoFleteID = item.sintDestinoFleteID,
                                    vchDestinoFlete = item.vchDestinoFlete,
                                    intElementoID = item.intElementoID,
                                    intCantidad = item.intCantidad,
                                    datFechaCarga = item.datFechaCarga,
                                    datFechaDescarga = item.datFechaDescarga
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
        /// Procedimiento que obtiene la lista de viaticos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="sintViaticoID"></param>
        /// <returns></returns>
        public List<DatosViaticos> ListarDatosViatico(int intCotizacionID, short sintViaticoID)
        {
            List<DatosViaticos> result = new List<DatosViaticos>();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosViatico(intCotizacionID, sintViaticoID)
                                select new DatosViaticos
                                {
                                    intDatoViaticoID = item.intDatoViaticoID,
                                    sintViaticoID = item.sintViaticoID,
                                    vchDescripcion = item.vchDescripcion,
                                    intUnidadMedicionID = item.intUnidadMedicionID,
                                    vchUnidadMedicion = item.vchUnidadMedicion,
                                    intInstalacion = item.intInstalacion,
                                    decFactor = item.decFactor,
                                    intCantidad = item.intCantidad,
                                    datFecha = item.datFecha,
                                    decCostoGolpe = item.decCostoGolpe,
                                    bitTieneCosto = item.bitTieneCosto
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
        /// Procedimiento que realiza el alta, modificación o baja de flete
        /// </summary>
        /// <param name="flete"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosFlete(DatosFlete flete, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosFlete(flete.intCotizacionID, flete.intDetCotizaID, flete.intDatoFleteID, flete.intElementoID,
                    flete.sintFleteID, flete.intCantidad, flete.datFechaCarga, flete.datFechaDescarga, flete.bitActivo,
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
        /// Procedimiento que realiza el alta, modificación y baja de instalación
        /// </summary>
        /// <param name="instalacion"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosInstalacion(DatosInstalacion instalacion, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosInstalacion(instalacion.intCotizacionID, instalacion.intDetCotizaID, instalacion.intDatosInstalacionID, instalacion.sintInstalacionID,
                        instalacion.intElementoID, instalacion.intCantidad, instalacion.datFecha, instalacion.bitActivo, (byte)tinOpcion)
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
        /// Procedimiento que realiza el alta, modificación y baja de viaticos
        /// </summary>
        /// <param name="viatico"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosViatico(DatosViaticos viatico, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (GastosDataContext dc = new GastosDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setDatosViatico(viatico.intCotizacionID, viatico.intDetCotizaID, viatico.intDatoViaticoID, viatico.intElementoID,
                        viatico.sintViaticoID, viatico.intCantidad, viatico.datFecha, viatico.decCostoGolpe, viatico.bitActivo, (byte)tinOpcion)
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
