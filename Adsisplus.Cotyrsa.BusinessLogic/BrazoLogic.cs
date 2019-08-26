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
        /// Procedimiento que lista el catálogo de largo de Brazo
        /// </summary>
        /// <returns></returns>
        public List<CatalogoDecimal> ListarCatLargoBrazo()
        {
            List<CatalogoDecimal> result = new List<CatalogoDecimal>();
            try
            {
                result = BrazoDA.ListarCatLargoBrazo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de brazo
        /// </summary>
        /// <param name="intBrazoID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosBrazo> ListarDatosBrazo(int intBrazoID, int intDetCotizaID)
        {
            List<DatosBrazo> result = new List<DatosBrazo>();
            try
            {
                result = BrazoDA.ListarDatosBrazo(intBrazoID, intDetCotizaID);
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
                detCotizacion.intElementoID = 2; // Falta definir el ID
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = brazo.intCantidad;
                detCotizacion.decMonto = brazo.decPrecioVentaTotal;
                detCotizacion.decSubtotal = Decimal.Round((Math.Truncate(100 * brazo.decPrecioVentaTotal.Value) / 100) * brazo.intCantidad.Value);

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
                        ListBrazo = ListarDatosBrazo((int)brazo.intBrazoID, intDetCotizaID);
                    // Validamos si existe registro
                    if (ListBrazo.Count() > 0)
                        _brazo = ListBrazo.First();
                    else
                        _brazo.intBrazoID = 0;
                    // Actualizamos la información
                    _brazo.bitActivo = brazo.bitActivo;
                    _brazo.decLargo = brazo.decLargo;
                    _brazo.decPesoTotal = brazo.decPesoTotal;
                    _brazo.decPesoUnitario = brazo.decPesoUnitario;
                    _brazo.decPrecioVentaTotal = brazo.decPrecioVentaTotal;
                    _brazo.decPrecioVentaUnitario = brazo.decPrecioVentaUnitario;
                    _brazo.intCantidad = brazo.intCantidad;
                    _brazo.intDetCotizaID = intDetCotizaID;
                    _brazo.intCotizacionID = intCotizacionID;
                    _brazo.intElementoID = 0;
                    _brazo.sintLargoBrazoID = brazo.sintLargoBrazoID;
                    _brazo.sintPinturaID = brazo.sintPinturaID;

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
