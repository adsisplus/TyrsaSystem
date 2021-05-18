using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Reportes
{
    public class Precios
    {
        public double Sistema { get; set; }

        public double Instalacion { get; set; }

        public double Traslado { get; set; }

        public double Total
        {
            get
            {
                return Sistema + Instalacion + Traslado;
            }
        }
    }
}
