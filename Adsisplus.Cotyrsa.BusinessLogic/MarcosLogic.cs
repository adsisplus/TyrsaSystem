﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;


namespace Adsisplus.Cotyrsa.BusinessLogic
{
  public class MarcosLogic
    {
        #region Constructor

        private MarcosDataAccess CatalogosDA;

        public MarcosLogic()
        {
            CatalogosDA = new MarcosDataAccess();

        }

        #endregion

        public List<Configuracion_Marco> ConfiguraMarco(Int32 intConfiguraMarcoID, Int32 intElementoID, Int16 sintTipoMarcoID, Int32 intAlturaMarcoID, Int16 sintFondoMarcoID, 
            Int32 intSKUID, Int16 sintFactorMarcoID, decimal decFondoMarco)
        {
            List<Configuracion_Marco> results = null;
            try
            {
                results = CatalogosDA.ConfiguraMarco(intConfiguraMarcoID, intElementoID, sintTipoMarcoID, intAlturaMarcoID, sintFondoMarcoID, intSKUID, sintFactorMarcoID, decFondoMarco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<RelSistemaCargaMarcoPoste> RelSistemaCargaMarcoPoste(Int16 sintSistemaCargaMarcoID, Int32 intSubProductoID, Int32 intCargaPosteID, Int32 intCargaMarcoID)
        {
            List<RelSistemaCargaMarcoPoste> results = null;
            try
            {
                results = CatalogosDA.RelSistemaCargaMarcoPoste(sintSistemaCargaMarcoID, intSubProductoID, intCargaPosteID, intCargaPosteID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<DatosMarco> ListarDatosMarco(Int32 intDatoMarcoID, Int32 intCotizacionID, Int32 intElementoID, Int16 sintPinturaID)
        {
            List<DatosMarco> results = null;
            try
            {
                results = CatalogosDA.ListarDatosMarco(intDatoMarcoID, intCotizacionID, intElementoID, sintPinturaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public List<FondoMarco> ListarFondoMarco(Int32 sintFondoMarcoID, Int32 sintTipoMarcoID, decimal decFondoMarco, int intCalibreAceroID)
        {
            List<FondoMarco> results = null;
            try
            {
                results = CatalogosDA.ListarFondoMarco(sintFondoMarcoID, sintTipoMarcoID, decFondoMarco, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }

        public Resultado ActualizaFactorMarco(Int16 sintFondoMarcoID, Decimal decCostoLamina, Decimal decCostoSolera, Decimal decFactorAcero, byte tinOpcion)
        {
            Resultado results = new Resultado();
            try
            {
                results = CatalogosDA.ActualizaFactorMarco(sintFondoMarcoID, decCostoLamina, decCostoSolera, decFactorAcero, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
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
                result = CatalogosDA.ListarCatFactorMarco();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Devuelve el catálogo de la capacidad de carga para un marco
        /// </summary>
        /// <returns></returns>
        public List<CargaMarco> ListarCatCargaMarco(int intCargaMarcoID, short sintTipoMarcoID, int intCalibreAceroID)
        {
            List<CargaMarco> result = new List<CargaMarco>();
            try
            {
                result = CatalogosDA.ListarCatCargaMarco(intCargaMarcoID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.ListarCatCargaPoste(intCargaPosteID, sintTipoMarcoID, intCalibreAceroID);
            }
            catch (Exception ex)
            {
                throw ex;
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
                result = CatalogosDA.setFondoMarco(factor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        #region Metodo para la selección de Marco
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
                result = decFondoTarimaVacia - Convert.ToDecimal(0.1524);
            }
            catch (Exception ex)
            {
                throw ex;
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
                CatalogoDecimal opcion = new CatalogoDecimal();
                decimal decLongitudViga = 0;
                // Obtenemos la primera opción
                decLongitudViga = Math.Round((decDimensionClaro + Convert.ToDecimal(intNumNivelesSobreVigaPeralte) + Convert.ToDecimal(0.30)), 0, MidpointRounding.AwayFromZero);
                // Agregamos la primera opción
                opcion.intCatalogoID = 1;
                opcion.decValor = decLongitudViga;
                result.Add(opcion);


                // Optenemos la segunda opción
                decLongitudViga = Math.Round((decAlturaPiso + Convert.ToDecimal(intNumNivelesSobreVigaClaro) + Convert.ToDecimal(intNumNivelesSobreVigaPeralte) + Convert.ToDecimal(0.30)), 0, MidpointRounding.AwayFromZero);
                // Agregamos la segunda opción
                opcion.intCatalogoID = 2;
                opcion.decValor = decLongitudViga;
                result.Add(opcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que permite listar los marcos en base a la capacidad
        /// de carga y la altura de pandeo
        /// </summary>
        /// <param name="decCapacidadCarga"></param>
        /// <param name="decAlturaPandeo"></param>
        /// <returns></returns>
        public List<SeleccionMarco> seleccionMarco(decimal decCapacidadCarga, decimal decAlturaPandeo, decimal decFondo, 
            decimal decAlturaMarco, short sintSistemaID, bool bitEstructural)
        {
            List<SeleccionMarco> result = new List<SeleccionMarco>();
            try
            {
                result = CatalogosDA.ListarSeleccionMarco(decCapacidadCarga, decAlturaPandeo, decFondo, decAlturaMarco, sintSistemaID, bitEstructural);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena toda la información de la pantalla de captura de Marco
        /// </summary>
        /// <param name="marco"></param>
        /// <param name="rack"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionMarco(SeleccionMarco marco, RackSelectivo rack, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setSeleccionMarco(marco, rack, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion

        /// <summary>
        /// Procedimiento para listar los fondos de marco
        /// </summary>
        /// <returns></returns>
        public List<decimal> ListarFondoMarco()
        {
            List<decimal> result = new List<decimal>();
            try
            {
                result = CatalogosDA.ListarFondoMarco();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

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
                result = CatalogosDA.ListarSeleccionMarco(decCapacidadCarga, decAlturaPandeo, decFondo, decAlturaMarco, sintSistemaID, bitEstructural);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que obtiene los datos a mostrar en patalla del marco
        /// </summary>
        /// <param name="intDetCotizacionID"></param>
        /// <returns></returns>
        public RackSelectivo ListarDatosPantallaMarco(int intDetCotizacionID)
        {
            RackSelectivo result = new RackSelectivo();
            try
            {
                result = CatalogosDA.ListarDatosPantallaMarco(intDetCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que muestra la seleccion del marco
        /// </summary>
        /// <param name="intSeleccionMarcoID"></param>
        /// <returns></returns>
        public SeleccionMarco ListarDatosSeleccionMarco(int intSeleccionMarcoID)
        {
            SeleccionMarco result = new SeleccionMarco();
            try
            {
                result = CatalogosDA.ListarDatosSeleccionMarco(intSeleccionMarcoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
