using Adsisplus.Cotyrsa.BusinessEntities.Reportes;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.FormatosCotizacionService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "FormatosCotizacionService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione FormatosCotizacionService.svc o FormatosCotizacionService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class FormatosCotizacionService : IFormatosCotizacionService
    {
        
        
        public Stream RetrieveFile(int cotizacionId)
        {
            if (WebOperationContext.Current == null) throw new Exception("WebOperationContext not set");

            FormatoCotizacionLogic cotizacion = new FormatoCotizacionLogic();

            // As the current service is being used by a windows client, there is no browser interactivity.  
            // In case you are using the code Web, please use the appropriate content type.  
            string path = cotizacion.BuildFormatoCotizacion(cotizacionId);//@"C:\Temp\PlantillasWord\Documento2222.docx";
            //string path = @"C:\temp\PlantillasWord\Documento2222.docx";
            var fileName = Path.GetFileName(path);
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/octet-stream";
            WebOperationContext.Current.OutgoingResponse.Headers.Add("content-disposition", "inline; filename=" + fileName);

            return File.OpenRead(path);
        }


        public void GuardarParametrosFormato(IEnumerable<ParametroCotizacion> parametrosFormato)
        {
            FormatoCotizacionLogic formatoLogic = new FormatoCotizacionLogic();
            formatoLogic.GuardarParametrosFormato(parametrosFormato);
        }

        public IEnumerable<ParametroCotizacion> GetParametrosFormatoCotizacion(int cotizacionId)
        {
            var parametros = new FormatoCotizacionLogic().GetParametrosFormato(cotizacionId);
            return parametros;
        }

        public bool TieneCantidadMinimaParametros(int cotizacionId)
            => new FormatoCotizacionLogic().VerificarParametrosFormatoCotizacion(cotizacionId);

        //public IEnumerable<ParametroCotizacion> parametrosFormato(int cotizacionId)
        //{

        //}
    }
}
