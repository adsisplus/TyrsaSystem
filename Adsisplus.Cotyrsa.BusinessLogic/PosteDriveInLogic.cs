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
        /// Procedimiento que lista los datos de piso DriveIn
        /// </summary>
        /// <param name="intDatosPisoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosPosteDriveIn> ListarDatosPosteDriveIn(int intDatoPosteDriveInID, int intDetCotizaID)
        {
            List<DatosPosteDriveIn> result = new List<DatosPosteDriveIn>();
            try
            {
                result = posteDA.ListarDatosPosteDriveIn(intDatoPosteDriveInID, intDetCotizaID);
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
                detCotizacion.intElementoID = 2; // Falta definir el ID
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = poste.intCantidad;
                detCotizacion.decMonto = poste.decPrecioTyrsa;
                detCotizacion.decSubtotal = poste.intCantidad * poste.decPrecioTyrsa;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    poste.intDetCotizaID = intDetCotizaID;

                    List<DatosPosteDriveIn> ListPoste = new List<DatosPosteDriveIn>();
                    DatosPosteDriveIn _poste = new DatosPosteDriveIn();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListPoste = ListarDatosPosteDriveIn((int)poste.intDatoPosteDriveInID, intDetCotizaID);
                    // Validamos si existe registro
                    if (ListPoste.Count() > 0)
                        _poste = ListPoste.First();
                    else
                        _poste.intDatoPosteDriveInID = 0;
                    // Actualizamos la información
                    _poste.bitActivo = poste.bitActivo;
                    _poste.decCalibre = poste.decCalibre;
                    _poste.decPrecioTyrsa = poste.decPrecioTyrsa;
                    _poste.decPrecioTyrsaKg = poste.decPrecioTyrsaKg;
                    _poste.decPrecioTyrsaMetro = poste.decPrecioTyrsaMetro;
                    _poste.decRelacionPrecios = poste.decRelacionPrecios;
                    _poste.decSolera = poste.decSolera;
                    _poste.decTotalKilo = poste.decTotalKilo;
                    _poste.intCantidad = poste.intCantidad;
                    _poste.intDetCotizaID = intDetCotizaID;
                    _poste.intElementoID = 0;
                    _poste.intSKUID = poste.intSKUID;
                    _poste.sintNumPosteReq = poste.sintNumPosteReq;
                    _poste.sintNumTravesanio = poste.sintNumTravesanio;

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
