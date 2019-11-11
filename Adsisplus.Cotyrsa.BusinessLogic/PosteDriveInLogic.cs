using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class PosteDriveInLogic
    {
        private PosteDriveInDataAccess posteDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public PosteDriveInLogic()
        {
            posteDA = new PosteDriveInDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista el precio poste TC 2
        /// </summary>
        /// <param name="intAlturaMarcoID"></param>
        /// <param name="decFondoMarco"></param>
        /// <returns></returns>
        public List<DatosPrecioPoste> ListarPrecioPosteTC2(int intAlturaMarcoID, decimal decFondoMarco)
        {
            List<DatosPrecioPoste> result = new List<DatosPrecioPoste>();
            try
            {
                result = posteDA.ListarPrecioPosteTC2(intAlturaMarcoID, decFondoMarco);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos poste drive in
        /// </summary>
        /// <param name="intDatoPosteDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        public List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intCotizacionID, int intDatoMarcoID)
        {
            List<DatosPosteDriveIn> result = new List<DatosPosteDriveIn>();
            try
            {
                result = posteDA.ListarDatosPosteDriveIn(intDatoPosteDriveInID, intCotizacionID, intDatoMarcoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los postes en base al id de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosPrecioPoste> ListarSeleccionPoste(int intCotizacionID)
        {
            List<DatosPrecioPoste> result = new List<DatosPrecioPoste>();
            try
            {
                result = posteDA.ListarSeleccionPoste(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result; 
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos Poste Drive In
        /// </summary>
        /// <param name="poste"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPosteDriveIn(DatosPosteDriveIn poste, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 31;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = poste.intCantidad;
                detCotizacion.decMonto = tinOpcion == 3 ? 0 : poste.seleccion.First().decPrecioTyrsa;
                detCotizacion.decSubtotal = tinOpcion == 3 ? 0 : poste.intCantidad * poste.seleccion.First().decPrecioTyrsa;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    poste.intDetCotizaID = intDetCotizaID;

                    List<DatosPosteDriveIn> ListPoste = new List<DatosPosteDriveIn>();
                    DatosPosteDriveIn _poste = new DatosPosteDriveIn();


                    if (tinOpcion != 1)
                        ListPoste = ListarDatosPosteDriveIn((int)poste.intDatoPosteDriveInID, intCotizacionID, (int)poste.intDatoMarcoID);
                    // Validamos si existe registro
                    if (ListPoste.Count() > 0)
                        _poste = ListPoste.First();
                    else
                    {
                        _poste.intDatoPosteDriveInID = 0;
                        tinOpcion = 1;
                    }
                    // Actualizamos la información
                    _poste.intCotizacionID = intCotizacionID;
                    _poste.intDetCotizaID = intDetCotizaID;
                    _poste.seleccion = new List<DatosPrecioPoste>();

                    if (tinOpcion != 3)
                    {
                        //_poste.decCalibre = poste.decCalibre;
                        //_poste.decPrecioTyrsa = poste.decPrecioTyrsa;
                        //_poste.decPrecioTyrsaKg = poste.decPrecioTyrsaKg;
                        //_poste.decPrecioTyrsaMetro = poste.decPrecioTyrsaMetro;
                        //_poste.decRelacionPrecios = poste.decRelacionPrecios;
                        //_poste.decSolera = poste.decSolera;
                        //_poste.decTotalKilo = poste.decTotalKilo;
                        _poste.bitActivo = poste.bitActivo;
                        _poste.intDatoMarcoID = poste.intDatoMarcoID;
                        _poste.intCantidad = poste.intCantidad;
                        _poste.bitDobleMonten = poste.bitDobleMonten;
                        _poste.decAlturaDobleMonten = poste.decAlturaDobleMonten;
                        _poste.intElementoID = 31;
                        //_poste.intSKUID = poste.intSKUID;
                        //_poste.sintNumPosteReq = poste.sintNumPosteReq;
                        //_poste.sintNumTravesanio = poste.sintNumTravesanio;
                        _poste.seleccion = poste.seleccion;
                    }
                    //Realizamos el registro del DRIVEIN
                    result = (new DriveInLogic()).setDatosPosteDriveIn(_poste, tinOpcion);
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
