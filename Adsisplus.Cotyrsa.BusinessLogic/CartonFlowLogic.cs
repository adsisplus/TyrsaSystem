using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class CartonFlowLogic
    {
        private CartonFlowDataAccess CartonFlowDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public CartonFlowLogic()
        {
            CartonFlowDA = new CartonFlowDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista el catálogo tipo carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <returns></returns>
        public List<Catalogo> ListarCatCalibreCartonFlow(short sintTipoCartonFlowID)
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = CartonFlowDA.ListarCatCalibreCartonFlow(sintTipoCartonFlowID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de Carton Flow
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatosCartonFlowID"></param>
        /// <returns></returns>
        public List<DatosCartonFlow> ListarDatosCartonFlow(int intCotizacionID, int intDatosCartonFlowID)
        {
            List<DatosCartonFlow> result = new List<DatosCartonFlow>();
            try
            {
                result = CartonFlowDA.ListarDatosCartonFlow(intCotizacionID, intDatosCartonFlowID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los datos de Carton Flow
        /// </summary>
        /// <param name="carton"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosCaronFlow(DatosCartonFlow carton, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 60; // // FALTA INGREGAR EL ELEMENTO AL CATÁLOGO
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = 0;
                detCotizacion.decMonto = 0;
                detCotizacion.decSubtotal = 0;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    carton.intDetCotizaID = intDetCotizaID;

                    List<DatosCartonFlow> ListCarton = new List<DatosCartonFlow>();
                    DatosCartonFlow _carton = new DatosCartonFlow();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListCarton = ListarDatosCartonFlow(intCotizacionID, (int)carton.intDatosCartonFlowID);
                    // Validamos si existe registro
                    if (ListCarton.Count() > 0)
                        _carton = ListCarton.First();
                    else
                        _carton.intDatosCartonFlowID = 0;

                    // Actualizamos la información
                    _carton = carton;
                    _carton.intElementoID = 60; // FALTA INGREGAR EL ELEMENTO AL CATÁLOGO
                    _carton.intCotizacionID = intCotizacionID;
                    // Realizamos el registro del Carton Flow
                    result = CartonFlowDA.setDatosCaronFlow(_carton, tinOpcion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los datos de perfil
        /// </summary>
        /// <param name="perfil"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPerfil(DatosPerfil perfil, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CartonFlowDA.setDatosPerfil(perfil, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta de los conectores carton flow
        /// </summary>
        /// <param name="conector"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosConectorCartonFlow(DatosConectorCartonFlow conector, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = CartonFlowDA.setDatosConectorCartonFlow(conector, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
