using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Shared.Utilities.Configuration
{
    /// <summary>
    /// Provides static data about global configuration
    /// </summary>
    /// <author>Fernando Ricardo Morán</author>
    public static class GlobalConfiguration
    {
        /// <summary>
        /// Obtiene el valor de una configuración de AppSettings incluída en el archivo de configuración
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSetting(string key)
        {
            string setting = ConfigurationManager.AppSettings[key];
            return setting;
        }

        
    }
}
