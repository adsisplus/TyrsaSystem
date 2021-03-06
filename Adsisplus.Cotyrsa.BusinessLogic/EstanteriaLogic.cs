﻿using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class EstanteriaLogic
    {
        private EstanteriaDataAccess EstanteriaDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public EstanteriaLogic()
        {
            EstanteriaDA = new EstanteriaDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos de entrepaño
        /// </summary>
        /// <param name="sintRefuerzo"></param>
        /// <param name="decFrente"></param>
        /// <param name="decFondo"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="bitGalvanizado"></param>
        /// <returns></returns>
        public List<SeleccionEntrepanio> ListarEntrepanio(short sintRefuerzo, decimal decFrente, decimal decFondo, int intCalibreAceroID, bool bitGalvanizado)
        {
            List<SeleccionEntrepanio> result = new List<SeleccionEntrepanio>();
            try
            {
                result = EstanteriaDA.ListarEntrepanio(sintRefuerzo, decFrente, decFondo, intCalibreAceroID, bitGalvanizado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de Entrepaño
        /// </summary>
        /// <param name="intEntrepanioID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosEntrepanio> ListarDatosEntrepanio(int intEntrepanioID, int intCotizacionID)
        {
            List<DatosEntrepanio> result = new List<DatosEntrepanio>();
            try
            {
                result = EstanteriaDA.ListarDatosEntrepanio(intEntrepanioID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de angulo ranurado en base a la capacidad de carga
        /// </summary>
        /// <param name="decCapacidadCarga"></param>
        /// <returns></returns>
        public List<SeleccionAnguloRanurado> ListarAnguloRanurado(decimal decCapacidadCarga)
        {
            List<SeleccionAnguloRanurado> result = new List<SeleccionAnguloRanurado>();
            try
            {
                result = EstanteriaDA.ListarAnguloRanurado(decCapacidadCarga);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion angulo ranurado almacenado
        /// </summary>
        /// <param name="intAnguloRanuradoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionAnguloRanurado> ListarSeleccionAnguloRanurado(int intAnguloRanuradoID, int intCotizacionID)
        {
            List<SeleccionAnguloRanurado> result = new List<SeleccionAnguloRanurado>();
            try
            {
                result = EstanteriaDA.ListarSeleccionAnguloRanurado(intAnguloRanuradoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// ¨Procedimiento que lista los datos de angulo ranurado
        /// </summary>
        /// <param name="intAnguloRanuradoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosAnguloRanurado> ListarDatosAnguladoRanurado(int intAnguloRanuradoID, int intCotizacionID)
        {
            List<DatosAnguloRanurado> result = new List<DatosAnguloRanurado>();
            try
            {
                result = EstanteriaDA.ListarDatosAnguladoRanurado(intAnguloRanuradoID, intCotizacionID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los valores de frente para entrepaño
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatFrenteEntrepanio()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = EstanteriaDA.ListarCatFrenteEntrepanio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los valores de fondo para entrepaño
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatFondoEntrepanio()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = EstanteriaDA.ListarCatFondoEntrepanio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los valores de calibre para estanteria
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibreEstanteria()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = EstanteriaDA.ListarCatCalibreEstanteria();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de selección de entrepañio
        /// </summary>
        /// <param name="intEntrepanioID"></param>
        /// <returns></returns>
        public List<SeleccionEntrepanio> ListarSeleccionEntrepanio(int intEntrepanioID)
        {
            List<SeleccionEntrepanio> result = new List<SeleccionEntrepanio>();
            try
            {
                result = EstanteriaDA.ListarSeleccionEntrepanio(intEntrepanioID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista las escuadra de refuerzo
        /// </summary>
        /// <returns></returns>
        public List<SeleccionEscuadraRefuerzo> ListarEscuadraRefuerzo()
        {
            List<SeleccionEscuadraRefuerzo> result = new List<SeleccionEscuadraRefuerzo>();
            try
            {
                result = EstanteriaDA.ListarEscuadraRefuerzo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos escuadra refuerzo
        /// </summary>
        /// <param name="intEscuadraRefID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosEscuadraRefuerzo> ListarDatosEscuadraRefuerzo(int intEscuadraRefID, int intCotizacionID)
        {
            List<DatosEscuadraRefuerzo> result = new List<DatosEscuadraRefuerzo>();
            try
            {
                result = EstanteriaDA.ListarDatosEscuadraRefuerzo(intEscuadraRefID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de selección
        /// </summary>
        /// <param name="intEscuadraRefID"></param>
        /// <returns></returns>
        public List<SeleccionEscuadraRefuerzo> ListarSeleccionEscuadraRefuerzo(int intEscuadraRefID)
        {
            List<SeleccionEscuadraRefuerzo> result = new List<SeleccionEscuadraRefuerzo>();
            try
            {
                result = EstanteriaDA.ListarSeleccionEscuadraRefuerzo(intEscuadraRefID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta y modificación de los datos entrepaños
        /// </summary>
        /// <param name="entrepanio"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosEntrepanio(DatosEntrepanio entrepanio, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 39;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = entrepanio.intCantidad;
                detCotizacion.decMonto = tinOpcion == 3 ? 0 : entrepanio.seleccion.decPrecioFinal;
                detCotizacion.decSubtotal = tinOpcion == 3 ? 0 : entrepanio.seleccion.decPrecioTotal;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    entrepanio.intDetCotizaID = intDetCotizaID;

                    List<DatosEntrepanio> ListEntre = new List<DatosEntrepanio>();
                    DatosEntrepanio _entre = new DatosEntrepanio();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListEntre = ListarDatosEntrepanio((int)entrepanio.intEntrepanioID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListEntre.Count() > 0)
                        _entre = ListEntre.First();
                    else
                        _entre.intEntrepanioID = 0;

                    _entre.intDetCotizaID = intDetCotizaID;
                    _entre.intCotizacionID = intCotizacionID;
                    _entre.intElementoID = 39;
                    _entre.seleccion = new SeleccionEntrepanio();
                    if (tinOpcion != 3)
                    {
                        // Actualizamos la información

                        _entre.sintTipoEntrepanioID = entrepanio.sintTipoEntrepanioID;
                        _entre.sintPinturaID = entrepanio.sintPinturaID;
                        _entre.intCalibreAceroID = entrepanio.intCalibreAceroID;
                        _entre.intCantidad = entrepanio.intCantidad;
                        _entre.bitGalvanizado = entrepanio.bitGalvanizado;
                        _entre.bitPintura = entrepanio.bitPintura;
                        _entre.sintRefuerzo = entrepanio.sintRefuerzo;
                        _entre.decFrente = entrepanio.decFrente;
                        _entre.decFondo = entrepanio.decFondo;
                        _entre.decPesoPartida = entrepanio.seleccion.decPrecioFinal;
                        _entre.decTotalKiloUnitario = entrepanio.seleccion.decTotalKiloUnitario;
                        //_entre.decPrecioVenta = entrepanio.seleccion.decPrecioFinal;
                        _entre.decPrecioFinal = entrepanio.seleccion.decPrecioFinal;
                        _entre.decPesoTotal = entrepanio.seleccion.decPesoTotal;
                        _entre.decPrecioTotal = entrepanio.seleccion.decPrecioTotal;
                        _entre.bitActivo = entrepanio.bitActivo;

                        // Insertamos los datos de la seleccion
                        _entre.seleccion = entrepanio.seleccion;
                    }
                    //Realizamos el registro del brazo
                    result = EstanteriaDA.setDatosEntrepanio(_entre, tinOpcion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta y modificación de los datos de angulo ranurado
        /// </summary>
        /// <param name="anguloRanurado"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAnguloRanurato(DatosAnguloRanurado anguloRanurado, int intDetCotizaID, int intCotizacionID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 41;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = anguloRanurado.intCantidad;
                detCotizacion.decMonto = tinOpcion == 3 ? 0 : anguloRanurado.seleccion.decPrecioUnitario;
                detCotizacion.decSubtotal = tinOpcion == 3 ? 0 : anguloRanurado.seleccion.decPrecioTotal;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    anguloRanurado.intDetCotizaID = intDetCotizaID;

                    List<DatosAnguloRanurado> ListAngulo = new List<DatosAnguloRanurado>();
                    DatosAnguloRanurado _angulo= new DatosAnguloRanurado();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListAngulo = ListarDatosAnguladoRanurado((int)anguloRanurado.intAnguloRanuradoID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListAngulo.Count() > 0)
                        _angulo = ListAngulo.First();
                    else
                        _angulo.intAnguloRanuradoID = 0;

                    _angulo.intDetCotizaID = intDetCotizaID;
                    _angulo.intCotizacionID = intCotizacionID;
                    _angulo.seleccion = new SeleccionAnguloRanurado();
                    if (tinOpcion != 3)
                    {
                        // Actualizamos la información

                        _angulo.sintTipoAnguloRanuradoID = anguloRanurado.sintTipoAnguloRanuradoID;
                        _angulo.intElementoID = detCotizacion.intElementoID;
                        _angulo.sintPinturaID = anguloRanurado.sintPinturaID;
                        _angulo.intCantidad = anguloRanurado.intCantidad;
                        _angulo.decLargo = anguloRanurado.decLargo;
                        _angulo.decCapacidadCarga = anguloRanurado.decCapacidadCarga;
                        _angulo.decPesoTotal = anguloRanurado.seleccion.decPesoTotal;
                        _angulo.decPrecioTotal = anguloRanurado.seleccion.decPrecioTotal;

                        // Insertamos los datos de la seleccion
                        _angulo.seleccion = anguloRanurado.seleccion;
                    }
                    //Realizamos el registro del brazo
                    result = EstanteriaDA.setDatosAnguloRanurado(_angulo, tinOpcion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos escuadra refuerzo
        /// </summary>
        /// <param name="escuadra"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosEscuadraRefuerzo(DatosEscuadraRefuerzo escuadra, int intDetCotizaID, int intCotizacionID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 40; // Escuadra de refuerzo
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = escuadra.intCantidad;
                detCotizacion.decMonto = escuadra.seleccion.decPrecioUnitario;
                detCotizacion.decSubtotal = escuadra.seleccion.decPrecioTotal;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    escuadra.intDetCotizaID = intDetCotizaID;

                    List<DatosEscuadraRefuerzo> ListEscuadra = new List<DatosEscuadraRefuerzo>();
                    DatosEscuadraRefuerzo _escuadra = new DatosEscuadraRefuerzo();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListEscuadra = ListarDatosEscuadraRefuerzo((int)escuadra.intEscuadraRefID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListEscuadra.Count() > 0)
                        _escuadra = ListEscuadra.First();
                    else
                        _escuadra.intEscuadraRefID = 0;

                    _escuadra.intDetCotizaID = intDetCotizaID;
                    _escuadra.intCotizacionID = intCotizacionID;
                    _escuadra.intElementoID = 40;
                    _escuadra.seleccion = new SeleccionEscuadraRefuerzo();
                    if (tinOpcion != 3)
                    {
                        // Actualizamos la información
                        _escuadra.intElementoID = 40;
                        _escuadra.intCantidad = escuadra.intCantidad;
                        _escuadra.decPesoUnitario = escuadra.seleccion.decPesoUnitario;
                        _escuadra.decPesoTotal = escuadra.seleccion.decPesoTotal;
                        _escuadra.decPrecioUnitario = escuadra.seleccion.decPrecioUnitario;
                        _escuadra.decPrecioTotal = escuadra.seleccion.decPrecioTotal;
                        _escuadra.seleccion = escuadra.seleccion;
                    }
                    //Realizamos el registro del brazo
                    result = EstanteriaDA.setDatosEscuadraRefuerzo(_escuadra, tinOpcion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
