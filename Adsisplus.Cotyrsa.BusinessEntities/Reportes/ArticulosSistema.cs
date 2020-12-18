using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Reportes
{
    public class ArticulosSistema
    {
        public string Referencia { get; set; }
        public string SKU { get; set; }
        public int Cantidad { get; set; }
        public string Elemento { get; set; }
        public string Descripcion { get; set; }
        public double PrecioTyrsa { get; set; }
        public double PesoUnitario { get; set; }
        public double CostoTotal { get; set; }
        public double FactorVenta { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioTotal { get; set; }
        public double PesoTotal { get; set; }

    }
}
