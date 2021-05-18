using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Reportes
{
    public class ReporteCotizacion
    {
        public string CotizacionId { get; set; }
        public DateTime FechaCotizacion { get; set; }

        public Sistema Sistema { get; set; }

        public Cliente Cliente { get; set; }

        public Usuario AsesorComercial { get; set; }

        public IEnumerable<ArticulosSistema> Elementos { get; set; }

        public IEnumerable<KeyValuePair<string,string>> GeneralData { get; set; }

        public IEnumerable<ArticulosSistema> Detalles { get; set; }

        public Precios Precios { get; set; }

    }
}
