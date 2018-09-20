﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adsisplus.Cotyrsa.WcfService.CatalogoGeneralServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CatalogoGeneralServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CatalogoGeneralServices.svc o CatalogoGeneralServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CatalogoGeneralServices : ICatalogoGeneralServices
    {
        /// <summary>
        /// Obtiene la lista de estados de la república mexicana
        /// </summary>
        /// <returns></returns>
        
        public List<Catalogo> ListarCatEstado()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatEstado();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de localidades en base al municipio seleccionado.
        /// </summary>
        /// <param name="int_MunicipioID"></param>
        /// <returns></returns>
        public List<Localidad> ListarCatLocalidad(int int_MunicipioID)
        {
            List<Localidad> result = new List<Localidad>();
            try
            {
                result = (new CatalogoLogic()).ListarCatLocalidad(int_MunicipioID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de municipios en base a un estado seleccionado
        /// </summary>
        /// <param name="intEstadoID"></param>
        /// <returns></returns>
        public List<Municipio> ListarCatMunicipio(int intEstadoID)
        {
            List<Municipio> result = new List<Municipio>();
            try
            {
                result = (new CatalogoLogic()).ListarCatMunicipio(intEstadoID);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de personalidades.
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPersonalidad()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatPersonalidad();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de prioridades.
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPrioridad()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatPrioridad();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de domicilios
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoDomicilio()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoDomicilio();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de empresa
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoEmpresa()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoEmpresa();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de tipos de personas
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatTipoPersona()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = (new CatalogoLogic()).ListarCatTipoPersona();
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}