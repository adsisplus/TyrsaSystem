﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.Services.MarcosService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.MarcosService
{
    public class MarcosServices : IMarcosServices
    {
        /// <summary>
        /// Obtiene la lista de las configuraciones de Marcos
        /// </summary>
        /// <param name="intConfiguraMarcoID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="intSKUID"></param>
        /// <param name="sintFactorMarcoID"></param>
        /// <returns></returns>
        public List<Configuracion_Marco> ConfiguraMarco(int intConfiguraMarcoID, int intElementoID, short sintTipoMarcoID, int intAlturaMarcoID, short sintFondoMarcoID, int intSKUID, short sintFactorMarcoID)
        {
            List<Configuracion_Marco> result = new List<Configuracion_Marco>();
            try
            {
                result = (new MarcosLogic()).ConfiguraMarco(intConfiguraMarcoID, intElementoID, sintTipoMarcoID, intAlturaMarcoID, sintFondoMarcoID, intSKUID, sintFactorMarcoID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de relaciones de sistema de carga de Marcos contra postes
        /// </summary>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="sintPinturaID"></param>
        /// <returns></returns>
        public List<DatosMarco> ListarDatosMarco(int intDatoMarcoID, int intCotizacionID, int intElementoID, short sintPinturaID)
        {
            List<DatosMarco> result = new List<DatosMarco>();
            try
            {
                result = (new MarcosLogic()).ListarDatosMarco(intDatoMarcoID, intCotizacionID, intElementoID, sintPinturaID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de datos de un marco en particular
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <returns></returns>
        public List<FondoMarco> ListarFondoMarco(int sintFondoMarcoID, int sintTipoMarcoID)
        {
            List<FondoMarco> result = new List<FondoMarco>();
            try
            {
                result = (new MarcosLogic()).ListarFondoMarco(sintFondoMarcoID, sintTipoMarcoID);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de fonto por un marco en particular
        /// </summary>
        /// <param name="sintSistemaCargaMarcoID"></param>
        /// <param name="intSubProductoID"></param>
        /// <param name="intCargaPosteID"></param>
        /// <param name="intCargaMarcoID"></param>
        /// <returns></returns>
        public List<RelSistemaCargaMarcoPoste> RelSistemaCargaMarcoPoste(short sintSistemaCargaMarcoID, int intSubProductoID, int intCargaPosteID, int intCargaMarcoID)
        {
            List<RelSistemaCargaMarcoPoste> result = new List<RelSistemaCargaMarcoPoste>();
            try
            {
                result = (new MarcosLogic()).RelSistemaCargaMarcoPoste(sintSistemaCargaMarcoID, intSubProductoID, intCargaPosteID, intCargaMarcoID);
            }
            catch(Exception ex)
            {

            }
            return result;
        }
    }
}
