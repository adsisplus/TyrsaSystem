using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessEntities.Reportes;
using Adsisplus.Cotyrsa.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.DataAccess
{
    public class FormatoCotizacionDataAccess
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cotizacionId"></param>
        /// <returns></returns>
        public ReporteCotizacion GetReporteCotizacion(int cotizacionId)
        {
            try
            {
                using (FormatoCotizacionDataContext cotizacionDataContext = new FormatoCotizacionDataContext(Helper.ConnectionString()))
                {
                    var query = cotizacionDataContext.stp_ListarReporteCotizacion(cotizacionId).Select(reporteCotizacion => new ReporteCotizacion
                    {
                        CotizacionId = reporteCotizacion.vchFolio,
                        Sistema = new Sistema
                        {

                            TipoSistema = reporteCotizacion.vchSistema,
                            Dimensiones = new Dimensiones
                            {
                                Frente = 3.14,
                                Fondo = 3.10,
                                Altura = 2.00,
                                Peso = 1000,
                                CargaMaxima = 2500
                            }
                        },
                        Cliente = new Cliente
                        {
                            Empresa = new Empresa
                            {
                                vchNombre = reporteCotizacion.vchEmpresa,
                                Direccion = "Centeno No. 486,\nCol. Granjas\nDel. Iztacalco"
                            },
                            Contacto = new Usuario
                            {
                                Nombre = "Francisco",
                                ApellidoPaterno = "González",
                                ApellidoMaterno = "Boca Negra",
                                Titulo = "Ingeniero"
                            }
                        },
                        AsesorComercial = new Usuario
                        {
                            Nombre = "Fernando",
                            ApellidoPaterno = "Ricardo",
                            ApellidoMaterno = "Morán",
                            Titulo = "Asesor Comercial"
                        },

                    });
                    ReporteCotizacion reporte = query.FirstOrDefault();
                    var materiales = cotizacionDataContext.Cotizacion_ListarMateriales(cotizacionId);

                    IEnumerable<ArticulosSistema> detalles = cotizacionDataContext.stp_ListarReporteDetalleCotizacion(cotizacionId).Select(detalle => new ArticulosSistema
                    {
                        Referencia = detalle.REF,
                        Descripcion = detalle.vchDescripcion,
                        PrecioTotal = Convert.ToDouble(detalle.PrecioTotal ?? default)
                    }).ToList();

                    reporte.Detalles = detalles;
                    //reporte.Elementos = detalles.Select(item => new ArticulosSistema
                    //{
                    //    Referencia = item.REF,
                    //    Cantidad = item.intCantidad ?? default,
                    //    SKU = $"{item.SKU}",
                    //    Descripcion = item.vchDescripcion
                    //});



                    reporte.Elementos = materiales.Select(material =>
                     new ArticulosSistema
                     {
                         Referencia = material.Ref,
                         Cantidad = material.Cantidad ?? 0,
                         Descripcion = material.Descripcion
                     }).ToList();
                    return reporte;
                }
            }
            catch (Exception exception)
            {

                throw;
            }

        }


        public void GuardarParametrosFormatoCotizacion(IEnumerable<ParametroCotizacion> parametrosFormato)
        {
            if (parametrosFormato?.Count() > 0)
            {
                using (FormatoCotizacionDataContext formatoCotizacionContext = new FormatoCotizacionDataContext(Helper.ConnectionString()))
                {
                    foreach (var parametro in parametrosFormato)
                    {
                        formatoCotizacionContext.ParametrosCotizacion_Insert(parametro.CotizacionId, parametro.Parameter, parametro.Value);

                    }
                }
            }

        }


        public IEnumerable<ParametroCotizacion> GetParametrosFormato(int cotizacionId)
        {
            List<ParametroCotizacion> listaParametros = new List<ParametroCotizacion>();
            using (FormatoCotizacionDataContext formatoCotizacionContext = new FormatoCotizacionDataContext(Helper.ConnectionString()))
            {

                var lista = formatoCotizacionContext.ParametrosCotizacion_GetByCotizacion(cotizacionId)?.Select(param => new ParametroCotizacion
                {
                    CotizacionId = param.CotizacionId,
                    Parameter = param.Parameter,
                    Value = param.ParameterValue
                })?.ToList();
                if (lista != null)
                {
                    listaParametros = lista;
                }
            }
            return listaParametros;
        }


        public class ElementoCotizacion
        {

            //private int _intCotizacionID;

            //private string _vchFolio;

            public string REF { get; set; }

            public Int16? SKU { get; set; }

            //private System.Nullable<int> _intPartida;

            public int? intCantidad { get; set; }

            //private string _vchElemento;

            public string vchDescripcion { get; set; }

            //private System.Nullable<decimal> _decPrecioTyrsa;

            //private System.Nullable<decimal> _decPesoUnitario;

            //private System.Nullable<decimal> _decCostoTotal;

            //private System.Nullable<decimal> _decFactorVenta;

            //private System.Nullable<decimal> _PrecioVenta;

            //private System.Nullable<decimal> _PrecioTotal;

            //private System.Nullable<decimal> _decPesoTotal;
        }
    }
}
