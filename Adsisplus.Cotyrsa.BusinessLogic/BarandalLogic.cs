using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class BarandalLogic
    {
        private BarandalDataAccess BarandalDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public BarandalLogic()
        {
            BarandalDA = new BarandalDataAccess();
        }
        /// <summary>
        /// Procedimiento que lista los datos Barandal
        /// </summary>
        /// <param name="intDatosBarandalID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosBarandal> ListarDatosBarandal(int intDatosBarandalID, int intCotizacionID)
        {
            List<DatosBarandal> result = new List<DatosBarandal>();
            try
            {
                result = BarandalDA.ListarDatosBarandal(intDatosBarandalID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        ///// <summary>
        ///// Procedimiento que lista los datos de precio DriveIn Barandal en base al largo
        ///// </summary>
        ///// <param name="decLargo"></param>
        ///// <returns></returns>
        //public List<SeleccionBarandal> ListarDriveInBarandal(decimal decLargo)
        //{
        //    List<SeleccionBarandal> result = new List<SeleccionBarandal>();
        //    try
        //    {
        //        result = BarandalDA.ListarDriveInBarandal(decLargo);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result;
        //}
        /// <summary>
        /// Procedimiento que realiza el alta, baja o modificación de los datos de barandal
        /// </summary>
        /// <param name="barandal"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBarandal(DatosBarandal barandal, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 22;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = tinOpcion == 3 ? 0 : Convert.ToInt32(barandal.intCantidad);
                detCotizacion.decMonto = tinOpcion == 3 ? 0 : barandal.decPrecioTotal;
                //detCotizacion.decSubtotal = Decimal.Round((Math.Truncate(100 * barandal.decPrecioTotal.Value) / 100) * barandal.decCantidad.Value);

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    barandal.intDetCotizaID = intDetCotizaID;

                    List<DatosBarandal> ListBarandal = new List<DatosBarandal>();
                    DatosBarandal _barandal = new DatosBarandal();

                    //Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListBarandal = ListarDatosBarandal((int)barandal.intDatosBarandalID, intCotizacionID);
                    //Validamos si existe registro
                    if (ListBarandal.Count > 0)
                        _barandal = ListBarandal.First();
                    else
                        _barandal.intDatosBarandalID = 0;

                    _barandal.intCotizacionID = intCotizacionID;
                    _barandal.intDetCotizaID = intDetCotizaID;

                    // actualizamos la información cuando se trata de un alta o modificación
                    if (tinOpcion != 3)
                    {
                        // Actualizamos la información
                        _barandal.intElementoID = 22;
                        _barandal.sintPinturaID = barandal.sintPinturaID;
                        _barandal.bitActivo = barandal.bitActivo;
                        _barandal.intCantidad = barandal.intCantidad;
                        _barandal.decLargo = barandal.decLargo;
                        _barandal.decPrecioTotal = barandal.decPrecioTotal;
                        _barandal.decPrecioUnitario = barandal.decPrecioUnitario;
                    }
                    // Realizamos el registro del atirantado
                    result = (new DriveInLogic()).setDatosBarandal(_barandal, tinOpcion);
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
