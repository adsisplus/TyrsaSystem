using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class EventLogManager
    {
        public static void LogErrorEntry(string errMensaje)
        {
            // Validamos si existe el repositorio
            if (!Directory.Exists("C:\\Log\\"))
                // Creamos el directorio
                Directory.CreateDirectory("C:\\Log\\Log.txt");
            File.AppendAllText("C:\\Log\\Log.txt", Environment.NewLine + DateTime.Now.ToShortDateString() + ' ' + errMensaje + "\r\n");
        }
    }
}
