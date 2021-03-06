﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.MarcosServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MarcosServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MarcosServices.svc o MarcosServices.svc.cs en el Explorador de soluciones e inicie la depuración.
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
        public List<Configuracion_Marco> ConfiguraMarco(int intConfiguraMarcoID, int intElementoID, short sintTipoMarcoID, int intAlturaMarcoID, short sintFondoMarcoID, int intSKUID, 
            short sintFactorMarcoID, decimal decFondoMarco)
        {
            List<Configuracion_Marco> result = new List<Configuracion_Marco>();
            try
            {
                result = (new MarcosLogic()).ConfiguraMarco(intConfiguraMarcoID, intElementoID, sintTipoMarcoID, intAlturaMarcoID, sintFondoMarcoID, intSKUID, 
                    sintFactorMarcoID, decFondoMarco);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de relaciones de sistema de carga de Marcos contra postes
        /// </summary>
        /// <param name="intDatoMarcoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosMarco> ListarDatosMarco(int intDatoMarcoID, int intCotizacionID)
        {
            List<DatosMarco> result = new List<DatosMarco>();
            try
            {
                result = (new MarcosLogic()).ListarDatosMarco(intDatoMarcoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista el fondo de Marco
        /// </summary>
        /// <returns></returns>
        public List<FondoMarco> ListarFondoMarco()
        {
            List<FondoMarco> result = new List<FondoMarco>();
            try
            {
                result = (new MarcosLogic()).ListarFondoMarco();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
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
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Cambia los factores de configuración para los marcos
        /// </summary>
        /// <param name="sintFondoMarcoID"></param>
        /// <param name="decCostoLamina"></param>
        /// <param name="decCostoSolera"></param>
        /// <param name="decFactorAcero"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado ActualizaFactorMarco(Int16 sintFondoMarcoID, Decimal decCostoLamina, Decimal decCostoSolera, Decimal decFactorAcero, byte tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new MarcosLogic()).ActualizaFactorMarco(sintFondoMarcoID, decCostoLamina, decCostoSolera, decFactorAcero, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista el catálogo de factores para los marcos
        /// </summary>
        /// <returns></returns>
        public List<FactorMarco> ListarCatFactorMarco()
        {
            List<FactorMarco> result = new List<FactorMarco>();
            try
            {
                result = (new MarcosLogic()).ListarCatFactorMarco();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Devuelve el catálogo de la capacidad de carga para un marco
        /// </summary>
        /// <param name="intCargaMarcoID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        public List<CargaMarco> ListarCatCargaMarco(int intCargaMarcoID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaMarco> result = new List<CargaMarco>();
            try
            {
                result = (new MarcosLogic()).ListarCatCargaMarco(intCargaMarcoID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la capacidad de carga de los postes
        /// </summary>
        /// <param name="intCargaPosteID"></param>
        /// <param name="sintTipoMarcoID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <returns></returns>
        public List<CargaPoste> ListarCatCargaPoste(int intCargaPosteID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaPoste> result = new List<CargaPoste>();
            try
            {
                result = (new MarcosLogic()).ListarCatCargaPoste(intCargaPosteID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Permite actualizar los factores del marco
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public Resultado setFondoMarco(FondoMarco factor)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new MarcosLogic()).setFondoMarco(factor);
            }
            catch(Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        #region SELECCION DE MARCO
        /// <summary>
        /// Obtiene el valor del fonde del marco
        /// </summary>
        /// <param name="decFondoTarimaVacia"></param>
        /// <returns></returns>
        public decimal getFondoMarco(decimal decFondoTarimaVacia)
        {
            decimal result = new decimal();
            try
            {
                result = (new MarcosLogic()).getFondoMarco(decFondoTarimaVacia);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Método que nos permite determinar la altura del Marco
        /// </summary>
        /// <param name="decDimensionClaro"></param>
        /// <param name="intNumNivelesSobreVigaClaro"></param>
        /// <param name="decAlturaPiso"></param>
        /// <param name="intNumNivelesSobreVigaPeralte"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public List<CatalogoDecimal> getAlturaMarco(decimal decDimensionClaro, int intNumNivelesSobreVigaClaro, decimal decAlturaPiso, int intNumNivelesSobreVigaPeralte)
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = (new MarcosLogic()).getAlturaMarco(decDimensionClaro, intNumNivelesSobreVigaClaro, decAlturaPiso, intNumNivelesSobreVigaPeralte);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        #endregion

        /// <summary>
        /// Procedimiento que permite listar los marcos en base a la capacidad
        /// de carga y la altura de pandeo
        /// </summary>
        /// <param name="decCapacidadCarga"></param>
        /// <param name="decAlturaPandeo"></param>
        /// <returns></returns>
        public List<SeleccionMarco> ListarSeleccionMarco(decimal decCapacidadCarga, decimal decAlturaPandeo, decimal decFondo,
            decimal decAlturaMarco, short sintSistemaID, bool bitEstructural)
        {
            List<SeleccionMarco> result = new List<SeleccionMarco>();
            try
            {
                result = (new MarcosLogic()).ListarSeleccionMarco(decCapacidadCarga, decAlturaPandeo, decFondo, decAlturaMarco, sintSistemaID, bitEstructural);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos del Marco seleccionado
        /// </summary>
        /// <param name="intSeleccionMarcoID"></param>
        /// <returns></returns>
        public List<SeleccionMarco> ListarDatosSeleccionMarco(int intCotizacionID)
        {
            List<SeleccionMarco> result = new List<SeleccionMarco>();
            try
            {
                result = (new MarcosLogic()).ListarDatosSeleccionMarco(intCotizacionID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que obtiene los datos a mostrar en patalla del marco
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <param name="intSeleccionMarcoID"></param>
        /// <returns></returns>
        public List<DatosPantallaMarco> ListarDatosPantallaMarco(int intDetCotizacionID, int intSeleccionMarcoID)
        {
            List<DatosPantallaMarco> result = new List<DatosPantallaMarco>();
            try
            {
                result = (new MarcosLogic()).ListarDatosPantallaMarco(intDetCotizacionID, intSeleccionMarcoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que revisa si el marco está ligado con otros elementos de la cotización
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public bool hayElementosVinculadosAlMarco(int intDetCotizaID)
        {
            bool result = false;
            try
            {
                result = (new MarcosLogic()).hayElementosVinculadosAlMarco(intDetCotizaID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que almacena toda la información de la pantalla de captura de Marco
        /// </summary>
        /// <param name="marco"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizacionID"></param>
        /// <param name="sintPinturaID"></param>
        /// <param name="intCantidad"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionMarco(DatosPantallaMarco marco, int intCotizacionID, int intDetCotizacionID, short sintPinturaID, int intCantidad, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new MarcosLogic()).setSeleccionMarco(marco, intCotizacionID, intDetCotizacionID, sintPinturaID, intCantidad, tinOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que realiza la baja lógica o física(en caso de existir un error) de los
        /// datos de Marco
        /// </summary>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitRollBack">1 = Borrado físico de la información </br>
        ///                         0 = Borrado lógico de la información</param>
        /// <returns></returns>
        public Resultado setBajaMarco(int intDetCotizaID, bool bitRollBack)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new MarcosLogic()).setBajaMarco(intDetCotizaID, bitRollBack);
            }
            catch(Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
