using Adsisplus.Cotyrsa.BusinessEntities.Reportes;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using Adsisplus.Cotyrsa.Shared.Utilities.Formats;
using System.Globalization;
using System.IO;
using System.Linq;
using Adsisplus.Cotyrsa.Shared.Utilities.Configuration;
using Adsisplus.Cotyrsa.Shared.Utilities.Configuration.Constants;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class FormatoCotizacionLogic
    {

        #region Properties

        private readonly FormatoCotizacionDataAccess FormatoCotizacionDataAccess;
        private readonly CultureInfo CultureInfo;
        private const int CantidadParametrosMinimos = 12;

        //private const string Outputfolder = @"C:\Temp\PlantillasWord";
        private readonly string FormatPath;
        private readonly string SubPathFilesFolder;

        private readonly string FormatOutputPath;

        #endregion

        #region Constructor



        public FormatoCotizacionLogic()
        {
            FormatoCotizacionDataAccess = new FormatoCotizacionDataAccess();
            CultureInfo = new CultureInfo("es-MX");

            FormatOutputPath = GlobalConfiguration.GetSetting(StringConstants.FormatsOutput);

            SubPathFilesFolder = GlobalConfiguration.GetSetting(StringConstants.FormatsSubrout);
            FormatPath = $"{Directory.GetCurrentDirectory()}{SubPathFilesFolder}";
        }

        #endregion



        #region Formato cotización

        private IEnumerable<KeyValuePair<string, string>> GetGeneralData(ReporteCotizacion ReporteCotizacionData)
        {
            return new List<KeyValuePair<string, string>>
            {
                 new KeyValuePair<string, string>("[@Fecha]",ReporteCotizacionData.FechaCotizacion.ToString("D",CultureInfo)),
                 new KeyValuePair<string, string>("[@FolioCot]",ReporteCotizacionData.CotizacionId),
                 new KeyValuePair<string, string>("[@NombreEmpresaCliente]",ReporteCotizacionData.Cliente.Empresa.vchNombre),
                 new KeyValuePair<string, string>("[@DomicilioCliente]",ReporteCotizacionData.Cliente.Empresa.Direccion),
                 new KeyValuePair<string, string>("[@TituloContactoCliente]",ReporteCotizacionData.Cliente.Contacto.Titulo),
                 new KeyValuePair<string, string>("[@NombreContactoCliente]",ReporteCotizacionData.Cliente.Contacto.GetFullName()),
                 new KeyValuePair<string, string>("[@TituloContactoCliente]",ReporteCotizacionData.Cliente.Contacto.Titulo),
                 new KeyValuePair<string, string>("[@NombreAsesor]",ReporteCotizacionData.AsesorComercial.GetFullName()),
                 new KeyValuePair<string, string>("[@PuestoAsesor]",ReporteCotizacionData.AsesorComercial.Titulo),
                 //Sistema
                 new KeyValuePair<string, string>("[@TipoSistema]",ReporteCotizacionData.Sistema.TipoSistema?.ToUpper()),
                 new KeyValuePair<string, string>("[@DimensionFrente]",Convert.ToString(ReporteCotizacionData.Sistema.Dimensiones.Frente,CultureInfo)),
                 new KeyValuePair<string, string>("[@DimensionFondo]",Convert.ToString(ReporteCotizacionData.Sistema.Dimensiones.Fondo,CultureInfo)),
                 new KeyValuePair<string, string>("[@DimensionAltura]",Convert.ToString(ReporteCotizacionData.Sistema.Dimensiones.Altura,CultureInfo)),
                 new KeyValuePair<string, string>("[@DimensionPeso]",Convert.ToString(ReporteCotizacionData.Sistema.Dimensiones.Peso,CultureInfo)),
                 new KeyValuePair<string, string>("[@DimensionCargaMaxima]",Convert.ToString(ReporteCotizacionData.Sistema.Dimensiones.CargaMaxima,CultureInfo)),

            };
        }



        public string BuildFormatoCotizacion(int cotizacionId)
        {
            try
            {
                ReporteCotizacion reportData = FormatoCotizacionDataAccess.GetReporteCotizacion(cotizacionId);
                BuildPrecios(reportData);

                string wordTemplatePath = GetTemplatePath(reportData.Sistema.TipoSistema);
                string outputCotizacionPath = GetFormatOutputPath(reportData);
                ReportGenerator ReportGenerator = new ReportGenerator(reportData);
                reportData.GeneralData = GetParametrosFormato(reportData, cotizacionId);
                ReportGenerator.BuildReport(wordTemplatePath, outputCotizacionPath);
                return outputCotizacionPath;
            }
            catch (Exception exception)
            {
                EventLogManager.LogErrorEntry(exception);
                throw;
            }
        }

        private void BuildPrecios(ReporteCotizacion reportData)
        {
            reportData.Precios = new Precios();
            foreach (var detalle in reportData.Detalles)
            {
                if (string.Equals("ins", detalle.Referencia, StringComparison.InvariantCultureIgnoreCase))
                {
                    reportData.Precios.Instalacion += detalle.PrecioTotal;
                }
                else if (string.Equals("fle", detalle.Referencia, StringComparison.InvariantCultureIgnoreCase) || string.Equals("via", detalle.Referencia, StringComparison.InvariantCultureIgnoreCase))
                {
                    reportData.Precios.Traslado += detalle.PrecioTotal;
                }
                else
                {
                    reportData.Precios.Sistema += detalle.PrecioTotal;
                }
            }
        }

        private string GetFormatOutputPath(ReporteCotizacion reportData)
        {
            string outputName = $"FormatoCotizacion_{reportData.CotizacionId}.docx";
            string outputDocumentPath = Path.Combine(FormatOutputPath, outputName);
            return outputDocumentPath;
        }


        private string GetTemplatePath(string tipoSistema)
        {
            //string formatsDirectory = GlobalConfiguration.GetSetting(StringConstants.FormatsDirectoryKey);//Path.Combine(Directory.GetCurrentDirectory(), subPathFormats);
            string fileName;
            switch (tipoSistema?.ToUpperInvariant())
            {
                case "SELECTIVO":
                    fileName = "SELECTIVO.docx";
                    break;
                case "DRIVE IN  & DRIVE THRU":
                    fileName = @"REDACCION DRIVE IN.docx";
                    break;
                case "CARTON FLOW":
                    fileName = @"REDACCION CARTON FLOW.docx";
                    break;
                case "DOBLE PROFUNDIDAD":
                    fileName = @"DOBLE PROFUNDIDAD.docx";
                    break;
                //case "S":
                default: throw new NotSupportedException("El formato para este tipo de sistema no ha sido definido");
            }
            string templatePath = Path.Combine(FormatPath, fileName);
            return templatePath;
        }


        private IEnumerable<KeyValuePair<string, string>> GetParametrosFormato(ReporteCotizacion reportData, int cotizacionId)
        {
            IEnumerable<KeyValuePair<string, string>> listaKeys = GetGeneralData(reportData);
            IEnumerable<KeyValuePair<string, string>> parametrosFormato = FormatoCotizacionDataAccess.GetParametrosFormato(cotizacionId).Select(param => new KeyValuePair<string, string>(param.Parameter, param.Value));
            IEnumerable<KeyValuePair<string, string>> precios = GetPrecios(reportData);
            return listaKeys.Concat(parametrosFormato).Concat(precios);
        }



        private IEnumerable<KeyValuePair<string, string>> GetPrecios(ReporteCotizacion reportData)
        {
            string format = "C";
            List<KeyValuePair<string, string>> precios = new List<KeyValuePair<string, string>> {
            new KeyValuePair<string, string>("[@PrecioSistema]",reportData.Precios.Sistema.ToString(format,CultureInfo)),
            new KeyValuePair<string, string>("[@PrecioServicio1]",reportData.Precios.Instalacion.ToString(format,CultureInfo)),
            new KeyValuePair<string, string>("[@PrecioServicio2]",reportData.Precios.Traslado.ToString(format,CultureInfo)),
            new KeyValuePair<string, string>("[@PrecioTotal]",reportData.Precios.Total.ToString(format,CultureInfo))
            };
            return precios;
        }
        #endregion



        #region Guarda parámetros de formato
        public void GuardarParametrosFormato(IEnumerable<ParametroCotizacion> parametrosFormato)
        {
            FormatoCotizacionDataAccess.GuardarParametrosFormatoCotizacion(parametrosFormato);
        }
        #endregion


        #region Obtiene los parametros de una cotización

        public IEnumerable<ParametroCotizacion> GetParametrosFormato(int cotizacionId)
            => FormatoCotizacionDataAccess.GetParametrosFormato(cotizacionId);

        #endregion


        #region Validar parametros de cotizador

        /// <summary>
        /// Verifica que tenga la cantidad mínima de parámetros para realizar el "Formato de Cotización"
        /// </summary>
        /// <param name="cotizacionId">Identificador de la cotización</param>
        /// <returns>Indica si tiene la cantidad mínima de parámetros</returns>
        /// <author>Fernando Ricardo Morán</author>
        public bool VerificarParametrosFormatoCotizacion(int cotizacionId)
        {
            try
            {
                var parametros = FormatoCotizacionDataAccess.GetParametrosFormato(cotizacionId);
                var cantidadParametros = parametros.Count(parametro => !string.IsNullOrWhiteSpace(parametro.Value));
                bool tieneCantidadMinimaDeParametros = cantidadParametros >= CantidadParametrosMinimos;

                return tieneCantidadMinimaDeParametros;

            }
            catch (Exception exception)
            {
                EventLogManager.LogErrorEntry(exception.Message);
                throw;
            }


        }
        #endregion

    }
}
