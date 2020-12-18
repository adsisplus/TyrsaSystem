using Adsisplus.Cotyrsa.BusinessEntities.Reportes;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using Adsisplus.Cotyrsa.Shared.Utilities.Formats;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class FormatoCotizacionLogic
    {

        #region Properties

        private readonly FormatoCotizacionDataAccess FormatoCotizacionDataAccess;
        private readonly CultureInfo CultureInfo;
        private const int CantidadParametrosMinimos = 12;

        private const string Outputfolder = @"C:\Temp\PlantillasWord";

        #endregion

        #region Constructor



        public FormatoCotizacionLogic()
        {
            FormatoCotizacionDataAccess = new FormatoCotizacionDataAccess();
            CultureInfo = new CultureInfo("es-MX");
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
                string wordTemplatePath = GetTemplatePath(reportData.Sistema.TipoSistema);
                string outputCotizacionPath = GetFormatOutputPath(reportData);
                //if (!File.Exists(outputCotizacionPath))//Si no existe, construye el reporte
                //{
                ReportGenerator ReportGenerator = new ReportGenerator(reportData);
                reportData.GeneralData = GetParametrosFormato(reportData, cotizacionId);
                ReportGenerator.BuildReport(wordTemplatePath, outputCotizacionPath);
                //}
                return outputCotizacionPath;//@"C:\Temp\PlantillasWord\Documento2222.docx";
            }
            catch (Exception exception)
            {
                EventLogManager.LogErrorEntry(exception);
                throw;
            }
        }

        private string GetFormatOutputPath(ReporteCotizacion reportData)
        {
            string outputName = $"FormatoCotizacion_{reportData.CotizacionId}.docx";
            string outputDocumentPath = Path.Combine(Outputfolder, outputName);
            return outputDocumentPath;
        }


        private string GetTemplatePath(string tipoSistema)
        {
            switch (tipoSistema?.ToUpperInvariant())
            {
                case "SELECTIVO":
                    return @"C:\Temp\PlantillasWord\SELECTIVO.docx";
                case "DRIVE IN  & DRIVE THRU":
                    return @"C:\Temp\PlantillasWord\REDACCION DRIVE IN.docx";
                case "CARTON FLOW":
                    return @"C:\Temp\PlantillasWord\REDACCION CARTON FLOW.docx";
                default: throw new NotSupportedException("El formato para este tipo de sistema no ha sido definido");
            }
        }


        private IEnumerable<KeyValuePair<string, string>> GetParametrosFormato(ReporteCotizacion reportData, int cotizacionId)
        {
            var listaKeys = GetGeneralData(reportData);
            var parametrosFormato = FormatoCotizacionDataAccess.GetParametrosFormato(cotizacionId).Select(param => new KeyValuePair<string, string>(param.Parameter, param.Value));
            return listaKeys.Concat(parametrosFormato);
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
