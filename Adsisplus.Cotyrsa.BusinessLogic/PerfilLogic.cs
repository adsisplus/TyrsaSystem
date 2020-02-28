using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class PerfilLogic
    {
        private PerfilDataAccess PerfilDA;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public PerfilLogic()
        {
            PerfilDA = new PerfilDataAccess();
        }
        /// <summary>
        /// Procedmiento que lista el catálogo de perfil carton Flow
        /// </summary>
        /// <returns></returns>
        public List<Catalogo> ListarCatPerfilCartonFlow()
        {
            List<Catalogo> result = new List<Catalogo>();
            try
            {
                result = PerfilDA.ListarCatPerfilCartonFlow();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos perfil carton flow
        /// </summary>
        /// <param name="sintTipoCartonFlowID"></param>
        /// <param name="intCalibreAceroID"></param>
        /// <param name="decLargoPerfil"></param>
        /// <returns></returns>
        public List<DatosPerfilCartonFlow> ListarPerfilCartonFlow(short sintTipoCartonFlowID, short intCalibreAceroID, decimal decLargoPerfil)
        {
            List<DatosPerfilCartonFlow> result = new List<DatosPerfilCartonFlow>();
            try
            {
                result = PerfilDA.ListarPerfilCartonFlow(sintTipoCartonFlowID, intCalibreAceroID, decLargoPerfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de perfil de Carton Flow
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intPerfilID"></param>
        /// <returns></returns>
        public List<DatosPerfil> ListarDatosPerfil(int intCotizacionID, int intPerfilID)
        {
            List<DatosPerfil> result = new List<DatosPerfil>();
            try
            {
                result = PerfilDA.ListarDatosPerfilCartonFlow(intCotizacionID, intPerfilID);
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
        public Resultado setDatosPerfil(DatosPerfil perfil, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                //detCotizacion.intElementoID = perfil.intElementoID;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = perfil.intCantidad;
                detCotizacion.decMonto = perfil.decPrecioUnitario;
                detCotizacion.decSubtotal = perfil.decPrecioTotal;

                // Obtenemos el tipo de elemento en base al tipo de perfil
                switch(perfil.sintTipoPerfilID)
                {
                    case 1: //Perfil de entrada
                        perfil.intElementoID = 23;
                        break;
                    case 2: // Perfil de salida
                        perfil.intElementoID = 24;
                        break;
                    case 3: case 4: case 5: //Perfil de Refuerzo
                        perfil.intElementoID = 25;
                        break;
                    case 6: // Perfil Lateral
                        perfil.intElementoID = 26;
                        break;
                    case 7: // Riel portaruedas calibre 14
                        perfil.intElementoID = 27;
                        break;
                    case 8: // Riel portaruedas calibre 12
                        perfil.intElementoID = 28;
                        break;
                    default:
                        perfil.intElementoID = 0;
                        break;
                }
                //Asignamos el valor a la cotización
                detCotizacion.intElementoID = perfil.intElementoID;
                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    perfil.intDetCotizaID = intDetCotizaID;

                    List<DatosPerfil> ListPerfil = new List<DatosPerfil>();
                    DatosPerfil _perfil = new DatosPerfil();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListPerfil = ListarDatosPerfil(intCotizacionID, (int)perfil.intPerfilID);
                    // Validamos si existe registro
                    if (ListPerfil.Count() > 0)
                        _perfil = ListPerfil.First();
                    else
                        _perfil.intPerfilID = 0;

                    // Actualizamos la información
                    _perfil = perfil;
                    _perfil.intCotizacionID = intCotizacionID;


                    // Realizamos el registro del Carton Flow
                    result = (new CartonFlowLogic()).setDatosPerfil(_perfil, tinOpcion);
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
