using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class BrazoLogic
    {
        private BrazoDataAccess BrazoDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public BrazoLogic()
        {
            BrazoDA = new BrazoDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos de brazo
        /// </summary>
        /// <param name="intBrazoID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosBrazo> ListarDatosBrazo(int intBrazoID, int intCotizacionID)
        {
            List<DatosBrazo> result = new List<DatosBrazo>();
            try
            {
                result = BrazoDA.ListarDatosBrazo(intBrazoID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista datos Drive In Brazo
        /// </summary>
        /// <param name="bitEsEstructural"></param>
        /// <returns></returns>
        public List<SeleccionBrazo> ListarDatosBrazoDriveIn(bool bitEsEstructural)
        {
            List<SeleccionBrazo> result = new List<SeleccionBrazo>();
            try
            {
                result = BrazoDA.ListarDatosBrazoDriveIn(bitEsEstructural);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de seleccion brazo en base al ID de la cotización
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<SeleccionBrazo> ListarSeleccionBrazo(int intCotizacionID)
        {
            List<SeleccionBrazo> result = new List<SeleccionBrazo>();
            try
            {
                result = BrazoDA.ListarSeleccionBrazo(intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación de los datos de brazo
        /// </summary>
        /// <param name="brazo"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBrazo(DatosBrazo brazo, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 30;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = brazo.intCantidad;
                detCotizacion.decMonto = tinOpcion == 3 ? 0 : brazo.seleccion.decPrecioVentaUnitario;
                detCotizacion.decSubtotal = tinOpcion == 3 ? 0 : brazo.seleccion.decPrecioVentaTotal;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    brazo.intDetCotizaID = intDetCotizaID;

                    List<DatosBrazo> ListBrazo = new List<DatosBrazo>();
                    DatosBrazo _brazo = new DatosBrazo();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListBrazo = ListarDatosBrazo((int)brazo.intBrazoID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListBrazo.Count() > 0)
                        _brazo = ListBrazo.First();
                    else
                        _brazo.intBrazoID = 0;

                    _brazo.intDetCotizaID = intDetCotizaID;
                    _brazo.intCotizacionID = intCotizacionID;
                    _brazo.seleccion = new SeleccionBrazo();
                    if (tinOpcion != 3)
                    {
                        // Actualizamos la información
                        //_brazo.seleccion = new SeleccionBrazo();
                        _brazo.bitActivo = brazo.bitActivo;
                        _brazo.decLargo = brazo.decLargo;
                        _brazo.intCantidad = brazo.intCantidad;

                        _brazo.intElementoID = 30;
                        _brazo.sintLargoBrazoID = brazo.sintLargoBrazoID;
                        _brazo.sintPinturaID = brazo.sintPinturaID;

                        // Insertamos los datos de la seleccion
                        _brazo.seleccion = brazo.seleccion;
                    }
                    //Realizamos el registro del brazo
                    result = (new DriveInLogic()).setDatosBrazo(_brazo, tinOpcion);
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
