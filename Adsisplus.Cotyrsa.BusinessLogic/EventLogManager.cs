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
                Directory.CreateDirectory("C:\\Log\\");
            File.AppendAllText("C:\\Log\\Log.txt", Environment.NewLine + DateTime.Now.ToShortDateString() + ' ' + errMensaje + "\r\n");


        }

        public static void LogErrorEntry(Exception exception)
        {
            string exceptionMessage = GetMessage(exception);
            // Validamos si existe el repositorio
            if (!Directory.Exists("C:\\Log\\"))
                // Creamos el directorio
                Directory.CreateDirectory("C:\\Log\\");
            File.AppendAllText("C:\\Log\\Log.txt", Environment.NewLine + DateTime.Now.ToShortDateString() + ' ' + exceptionMessage + "\r\n");
        }

        private static string GetMessage(Exception exception)
        {
            string message = exception?.Message;
            if (exception?.StackTrace != null)
            {
                message = $"{message}{Environment.NewLine}StackTrace:{exception.StackTrace}";
            }
            if (exception.InnerException != null)
            {
                message += $"{Environment.NewLine}InnserException:{GetMessage(exception.InnerException)}";
            }
            return message ?? string.Empty;
        }
    }
}
