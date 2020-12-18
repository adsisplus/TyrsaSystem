using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessEntities.Reportes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Shared.Utilities.Formats
{
    public class ReportGenerator
    {

        private readonly IEnumerable<KeyValuePair<string, int>> OrdenArticulos;
        private readonly ReporteCotizacion ReporteCotizacionData;

        public ReportGenerator(ReporteCotizacion reporteCotizacionData)
        {
            ReporteCotizacionData = reporteCotizacionData;
            OrdenArticulos = GetOrdenes();
        }

        public void BuildReport(string templatePath, string ouputPath)
        {
            var materiales = GetMateriales();
            using (WordWriter writer = new WordWriter(templatePath))
            {
                writer.ReplaceGenericData(ReporteCotizacionData.GeneralData);
                writer.CreateTableByTag(materiales, "TablaMateriales");
                writer.SaveAndClose(ouputPath);
            }
        }


        public List<string[]> GetMateriales()
        {
            List<string[]> listaMateriales = new List<string[]>();
            int numArticulo = 0;
            foreach (var articulo in ReporteCotizacionData.Elementos)
            {
                numArticulo++;
                string numArticuloString = numArticulo < 10 ? $"0{numArticulo}" : $"{numArticulo}";
                string[] materialRowData = new string[] { numArticuloString, $"{articulo.Referencia}", $"{articulo.Cantidad }", "PZAS.", $"{articulo.Descripcion}" };
                listaMateriales.Add(materialRowData);
            }
            string[] headers = new string[] { "PDA", "REF", "CANT", "UNID", "DESCRIPCIÓN" };
            listaMateriales.Insert(0, headers);
            return listaMateriales;
        }

        public IEnumerable<ArticulosSistema> GetOrderedItems()
            => ReporteCotizacionData.Elementos.OrderBy(articulo =>
             {
                 try
                 {
                     string referencia = articulo.Referencia.Replace(" ", string.Empty);
                     var ordenKeyValue = OrdenArticulos.FirstOrDefault(referenciaOrden => referencia.Contains(referenciaOrden.Key));
                     return ordenKeyValue.Value;
                 }
                 catch (Exception)
                 {
                     return int.MaxValue;
                 }
             }).ToList();

        private IEnumerable<KeyValuePair<string, int>> GetOrdenes()
        {
            string[] ReferenciasMateriales = new string[] { "TC", "VC", "VL", "D-1", "CB", "P-1", "VT", "PP", "PB-2", "PB-3", "PB-4", "CZ", "TQ", "TOR" };
            return Enumerable.Range(default, ReferenciasMateriales.Length)
                .Select(numOrden => new KeyValuePair<string, int>(ReferenciasMateriales[numOrden], numOrden + 1));
        }
    }
}
