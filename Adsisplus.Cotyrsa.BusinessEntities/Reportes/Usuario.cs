using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Reportes
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Titulo { get; set; }


        public string GetFullName()
            => $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}";

        public string GetFullNameWithTitle()
            => $"{Titulo} {GetFullName()}";
    }
}
