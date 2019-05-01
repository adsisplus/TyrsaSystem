using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;


namespace Adsisplus.Cotyrsa.BusinessLogic
{
   public class DistanciadorLogic
    {
        #region Constructor

        private DistanciadorDataAccess CatalogosDA;

        public DistanciadorLogic()
        {
            CatalogosDA = new DistanciadorDataAccess();

        }

        #endregion
        /// <summary>
        /// Procedimiento que lista los datos del distanciador en base a la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosDistanciador> ListarDatosDistanciador(Int32 intCotizacionID)
        {
            List<DatosDistanciador> results = null;
            try
            {
                results = CatalogosDA.ListarDatosDistanciador(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return results;
        }
        /// <summary>
        /// Obtiene la lista de distanciadores en base al altura
        /// </summary>
        /// <param name="decAltura"></param>
        /// <returns></returns>
        public List<SeleccionDistanciador> ListarSeleccionDistanciador(decimal decAltura)
        {
            List<SeleccionDistanciador> result = new List<SeleccionDistanciador>();
            try
            {
                result = CatalogosDA.ListarSeleccionDistanciador(decAltura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista de valores de altura de distanciador
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatalogoDistanciador()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = CatalogosDA.ListarCatalogoDistanciador();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que almacena los datos del Distanciador
        /// </summary>
        /// <param name="distanciador"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDistanciador(DatosDistanciador distanciador, SeleccionDistanciador seleccionDistanciador, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            int? intDistanciadorID;
            int? intSeleccionDistanciadorID;

            try
            {
                // Obtenemos la información del sistema Selectivo
                RelSistemaSelectivo sistema = (new CotizacionLogic()).ListarDatosSistemaSelectivo((int)distanciador.intCotizacionID);
                intDistanciadorID = null;

                // Procedemos a llenar la entidad de la cotización
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intElementoID = 5; // ID correspondiente a Distanciador
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = distanciador.intCantidadDistanciador;
                detCotizacion.decMonto = seleccionDistanciador.decPrecioTyrsa;
                detCotizacion.decSubtotal = seleccionDistanciador.decPrecioTyrsa * distanciador.intCantidadDistanciador;

                // 1. Realizamos el alta de la cotización
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(distanciador.intDetCotizaID == 0 ? 1 : tinOpcion));
                // Validamos la respuesta obtenida
                if (result.vchResultado != "NOK")
                {
                    // Almacenamos el ID del detalle de la cotización
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    distanciador.intDetCotizaID = intDetCotizaID;

                    // Almacenamos la seleccion del distanciador
                    seleccionDistanciador.intDetCotizaID = intDetCotizaID;

                    // 1. Se realiza el registro de la viga en las tablas tbl_RackSelectivo y tbl_SeleccionDistanciador, 
                    // devolverá el intSeleccionDistanciadorID
                    if (seleccionDistanciador.intSeleccionDistanciadorID != null)
                        // En caso de que exista valor en el ID, solo actualizamos los valores
                        result = CatalogosDA.setSeleccionDistanciador(seleccionDistanciador, tinOpcion);
                    else
                        // En caso contrario, realizamos la inserción
                        result = CatalogosDA.setSeleccionDistanciador(seleccionDistanciador, 1);

                    if (result.vchResultado != "NOK")
                    {
                        intSeleccionDistanciadorID = Convert.ToInt32(result.vchResultado);
                        List<DatosDistanciador> listMstDistanciador = new List<DatosDistanciador>();
                        DatosDistanciador mstDistanciador = new DatosDistanciador();

                        // Validamos si es un nuevo registro
                        if (tinOpcion != 1)
                            //Buscamos los datos de la maestra distanciador
                            listMstDistanciador = CatalogosDA.ListarDatosDistanciador(intCotizacionID);
                        // En caso de existir, obtenermos el primer registro
                        if (listMstDistanciador.Count() > 0)
                            mstDistanciador = listMstDistanciador.First();
                        else
                            mstDistanciador.intDistanciadorID = 0;

                        // Insertamos los datos capturados
                        mstDistanciador.intDetCotizaID = intDetCotizaID;
                        mstDistanciador.intCotizacionID = intCotizacionID;
                        mstDistanciador.sintPinturaID = distanciador.sintPinturaID;
                        mstDistanciador.intCantidadDistanciador = distanciador.intCantidadDistanciador;
                        mstDistanciador.decLargoDistanciador = distanciador.decLargoDistanciador;

                        // Procedeimos a realizar el almacenado de la información
                        result = (new SistemasTyrsaLogic()).setDatosDistanciador(mstDistanciador, tinOpcion);

                        intDistanciadorID = Convert.ToInt32(result.vchResultado);
                        if ((sistema.intDistanciadorID == null || sistema.intDistanciadorID == 0) || tinOpcion == 3)
                        {
                            // En caso de realizar la baja, establecemos el valor a 0
                            if (tinOpcion == 3)
                                sistema.intDistanciadorID = 0;
                            else
                                sistema.intDistanciadorID = intDistanciadorID;

                            sistema.intTipoElementoAlmacenID = 17;
                            sistema.intCotizacionID = distanciador.intCotizacionID;

                            result = (new CotizacionLogic()).setDatosRelSistemaSelectivo(sistema, 2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que realiza el alta de la seleccion distanciador
        /// </summary>
        /// <param name="distanciador"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setSeleccionDistanciador(SeleccionDistanciador distanciador, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CatalogosDA.setSeleccionDistanciador(distanciador, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
