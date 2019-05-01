using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess.Context;

namespace Adsisplus.Cotyrsa.DataAccess
{
   public class DistanciadorDataAccess
    {
        /// <summary>
        /// Procedimiento que lista los datos del distanciador en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosDistanciador> ListarDatosDistanciador(Int32 intCotizacionID)
        {
            List<DatosDistanciador> results = new List<DatosDistanciador>();
            try
            {
                using (DistanciadorDataContext dc = new DistanciadorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarDatosDistanciador(intCotizacionID)
                                select new DatosDistanciador()
                                {
                                    intDistanciadorID = item.intDistanciadorID,
                                    intCotizacionID = item.intCotizacionID,
                                    intDetCotizaID = item.intDetCotizaID,
                                    vchFolio = item.vchFolio,
                                    intElementoID = item.intElementoID,
                                    vchElemento = item.vchElemento,
                                    sintPinturaID = item.sintPinturaID,
                                    vchPintura = item.vchPintura,
                                    intCantidadDistanciador = item.intCantidadDistanciador,
                                    decLargoDistanciador = item.decLargoDistanciador,
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
        /// Obtiene la lista de distanciadores en base al altura
        /// </summary>
        /// <param name="decAltura"></param>
        /// <returns></returns>
        public List<SeleccionDistanciador> ListarSeleccionDistanciador(decimal decAltura)
        {
            List<SeleccionDistanciador> result = new List<SeleccionDistanciador>();
            try
            {
                using (DistanciadorDataContext dc = new DistanciadorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarSeleccionDistanciador(decAltura)
                                select new SeleccionDistanciador
                                {
                                    vchSKU = item.vchSKU,
                                    decAltura = item.decAltura,
                                    decPesoKg = item.decPesoKg,
                                    decPrecioTyrsa = item.decPrecioTyrsa,
                                    decPrecioReferencia = item.decPrecioReferencia,
                                    decRelacionPrecio = item.decRelacionPrecio,
                                    decPrecioMetroTyrsa = item.decPrecioMetroTyrsa,
                                    decPrecioMetroRef = item.decPrecioMetroRef,
                                    decPrecioKgTyrsa = item.decPrecioKgTyrsa,
                                    decPrecioKgRef = item.decPrecioKgRef,
                                    decPesoAnguloCobro = item.decPesoAnguloCobro,
                                    decPesoPlacaCobro = item.decPesoPlacaCobro,
                                    sintCantidadPzaAngulo = item.sintCantidadPzaAngulo,
                                    sintCantidadPzaPlaca = item.sintCantidadPzaPlaca,
                                    decPesoPorDistanciador = item.decPesoPorDistanciador,
                                    decAreaPinturaAngulo = item.decAreaPinturaAngulo,
                                    decAreaPinturaPlaca = item.decAreaPinturaPlaca,
                                    decPinturaTotal = item.decPinturaTotal,
                                    decTotalKgTotal = item.decTotalKgTotal,
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
        /// Obtiene la lista de valores de altura de distanciador
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatalogoDistanciador()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                using (DistanciadorDataContext dc = new DistanciadorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_ListarCatAlturaDistanciador()
                                select new CatalogoDecimal
                                {
                                    decValor = item.decAltura
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
        /// Procedimiento que realiza el alta de la seleccion distanciador
        /// </summary>
        /// <param name="distanciador"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionDistanciador(SeleccionDistanciador distanciador, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                using (DistanciadorDataContext dc = new DistanciadorDataContext(Helper.ConnectionString()))
                {
                    var query = from item in dc.stp_setSeleccionDistanciador(distanciador.intSeleccionDistanciadorID, distanciador.intRackID, distanciador.intDetCotizaID, distanciador.vchSKU,
                        distanciador.decAltura, distanciador.decPesoKg, distanciador.decPrecioTyrsa, distanciador.decPrecioReferencia,
                        distanciador.decRelacionPrecio, distanciador.decPrecioMetroTyrsa, distanciador.decPrecioMetroRef, distanciador.decPrecioKgRef,
                        distanciador.decPrecioKgRef, distanciador.decPesoAnguloCobro, distanciador.decPesoPlacaCobro, distanciador.sintCantidadPzaAngulo,
                        distanciador.sintCantidadPzaPlaca, distanciador.decPesoPorDistanciador, distanciador.decAreaPinturaAngulo, distanciador.decAreaPinturaPlaca,
                        distanciador.decPinturaTotal, distanciador.decTotalKgTotal, (byte)tinOpcion)
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
