using System;
using System.IO;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    /// <summary>
    /// Provides methods to register message
    /// </summary>
    public class EventLogManager
    {
        /// <summary>
        /// Log local path directory
        /// </summary>
        private const string LogDirectory = @"C:\Log";

        /// <summary>
        /// Writes message error in log file
        /// </summary>
        /// <param name="errMensaje">Error message</param>
        /// <author>Fernando Ricardo Morán</author>
        public static void LogErrorEntry(string errMensaje)
        {
            // Validamos si existe el repositorio
            if (!Directory.Exists(LogDirectory))
            {
                // Creamos el directorio
                Directory.CreateDirectory(LogDirectory);
            }
            string fileName = $"{DateTime.Now:yyyymmdd}.txt";
            string LogFullFileName = Path.Combine(LogDirectory, fileName);
            string messageLog = $"{Environment.NewLine}{DateTime.Now:yyyymmdd}: {errMensaje}{Environment.NewLine}";
            File.AppendAllText(LogFullFileName, messageLog);
        }


        /// <summary>
        /// Writes error stack trace
        /// </summary>
        /// <param name="exception">Exception to write</param>
        /// <author>Fernando Ricardo Morán</author>
        public static void LogErrorEntry(Exception exception)
        {
            string exceptionMessage = GetMessage(exception);
            LogErrorEntry(exceptionMessage);
        }

        /// <summary>
        /// Get stack trace error message
        /// </summary>
        /// <param name="exception">Exception to write</param>
        /// <returns>stack trace error message</returns>
        /// <author>Fernando Ricardo Morán</author>
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
