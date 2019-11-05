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
                detCotizacion.intElementoID = perfil.intElementoID;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = 0;
                detCotizacion.decMonto = 0;
                detCotizacion.decSubtotal = 0;

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
