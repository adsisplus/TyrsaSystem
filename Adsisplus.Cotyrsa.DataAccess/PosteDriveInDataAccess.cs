using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class PosteDriveInDataAccess
    {
        public List<DatosPantallaMarco> ListarDatosMarcoDriveIn(int intCotizacionID, int intDatoMarcoID)
        {
            List<DatosPantallaMarco> result = new List<DatosPantallaMarco>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosMarcoDriveIn(intCotizacionID, intDatoMarcoID)
                                select new DatosPantallaMarco
                                {
                                    seleccion = new SeleccionMarco()
                                    {
                                        //intRackID = item.intRackID,
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos poste drive in
        /// </summary>
        /// <param name="intDatoPosteDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intCotizacionID, int intDatoMarcoID)
        {
            List<DatosPosteDriveIn> result = new List<DatosPosteDriveIn>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query_1 = from item in dc.stp_ListarDatosPosteDriveIn(intDatoPosteDriveInID, intCotizacionID, intDatoMarcoID)
                                select new DatosPosteDriveIn
                                {
                                     intDatoPosteDriveInID = item.intDatoPosteDriveInID,
                                    intElementoID = item.intElementoID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    intDatoMarcoID = item.intDatoMarcoID,
                                    intAlturaMarcoID = item.intAlturaMarcoID,
                                    decFondo = item.decFondo,
                                    intSeleccionMarcoID = item.intSeleccionMarcoID,
                                    intDetCotizaID_Marco = item.intDetCotizaID_Marco,
                                };
                    result.AddRange(query_1);
                    if (result.Count() > 0)
                        for (int i = 0; i < result.Count(); i++)
                        {
                            var query_2 = from item in dc.stp_ListarDatosPosteDriveIn(result[i].intDatoPosteDriveInID, result[i].intCotizacionID, result[i].intDatoMarcoID)
                                        select new DatosPrecioPoste
                                        {
                                            decPrecioVentaTotal = item.decPrecioVentaTotal,
                                            decPesoTotal = item.decPesoTotal,
                                            decTotalKilo = item.decTotalKilo,
                                            decPrecioTyrsa = item.decPrecioTyrsa,
                                            decCalibre = item.decCalibre,
                                            decPrecioTyrsaKg = item.decPrecioTyrsaKg,
                                            decPrecioTyrsaMetro = item.decPrecioTyrsaMetro,
                                            decRelacionPrecios = item.decRelacionPrecios,
                                            decSolera = item.decSolera,
                                            sintNumPosteReq = item.sintNumPosteReq,
                                            sintNumTravesanio = item.sintNumTravesanio
                                        };
                            result[i].seleccion = new List<DatosPrecioPoste>();
                            // Obtenemos la lista de precios
                            result[i].seleccion.AddRange(query_2);
                        }
                    if(result.Count() > 0)
                        for(int i=0; i<result.Count(); i++)
                            // Obtenemos la información de pantalla de marco
                            result[i].datosMarco = ListarDatosMarcoDriveIn((int)result[i].intCotizacionID, (int)result[i].intDatoMarcoID).Count() == 0 ? null :
                                ListarDatosMarcoDriveIn((int)result[i].intCotizacionID, (int)result[i].intDatoMarcoID).First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los postes en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPrecioPoste> ListarSeleccionPoste(int intCotizacionID)
        {
            List<DatosPrecioPoste> result = new List<DatosPrecioPoste>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosPosteDriveIn(0, intCotizacionID, 0)
                                select new DatosPrecioPoste
                                {
                                    decPrecioVentaTotal = item.decPrecioVentaTotal,
                                    decPesoTotal = item.decPesoTotal,
                                    decTotalKilo = item.decTotalKilo,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    decCalibre = item.decCalibre,
                                    decPrecioTyrsaKg = item.decPrecioTyrsaKg,
                                    decPrecioTyrsaMetro = item.decPrecioTyrsaMetro,
                                    decRelacionPrecios = item.decRelacionPrecios,
                                    decSolera = item.decSolera,
                                    sintNumPosteReq = item.sintNumPosteReq,
                                    sintNumTravesanio = item.sintNumTravesanio
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
        /// Procedimiento que lista el precio poste TC 2
        /// </summary>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="decFondoMarco"></param>
        /// <returns></returns>
        public List<DatosPrecioPoste> ListarPrecioPosteTC2(int intAlturaMarcoID, decimal decFondoMarco)
        {
            List<DatosPrecioPoste> result = new List<DatosPrecioPoste>();
            try
            {
                using (PosteDriveInDataContext dc = new PosteDriveInDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarPrecioPosteTC2(intAlturaMarcoID, decFondoMarco)
                                select new DatosPrecioPoste
                                {
                                    intConfiguraMarcoID = item.intConfiguraMarcoID,
                                    intSKUID = item.intSKUID,
                                    decCalibre = item.decCalibre,
                                    decSolera = item.decSolera,
                                    decTotalKilo = item.decTotalKilo,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    decRelacionPrecios = item.decRelacionPrecios,
                                    decPrecioTyrsaMetro = item.decPrecioTyrsaMetro,
                                    decPrecioTyrsaKg = item.decPrecioTyrsaKg,
                                    sintNumPosteReq = item.sintNumPosteReq,
                                    sintNumTravesanio = item.sintNumTravesanio
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
