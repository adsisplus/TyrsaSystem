using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Reportes
{
    public class Cliente
    {
        public Empresa Empresa { get; set; }
        public Usuario Contacto { get; set; }
    }
}
