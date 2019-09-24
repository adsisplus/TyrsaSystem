using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class DriveInLogic
    {
        private DriveInDataAccess DriveInDA;
        /// <summary>
        /// Constructor
        /// </summary>
        public DriveInLogic()
        {
            DriveInDA = new DriveInDataAccess();
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos Atirantado
        /// </summary>
        /// <param name="atirantado"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosAtirantado(DatosAtirantado atirantado, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosAtirantado(atirantado, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, baja y modificación de los datos Viga Atirantado
        /// </summary>
        /// <param name="vigaAti"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosVigaAtirantado(DatosVigaAtirantado vigaAti, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosVigaAtirantado(vigaAti, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de los datos Brazo
        /// </summary>
        /// <param name="brazo"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBrazo(DatosBrazo brazo, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosBrazo(brazo, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de los datos Riel Tarima
        /// </summary>
        /// <param name="riel"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosRielTarima(DatosRielTarima riel, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosRielTarima(riel, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de los datos guia entrada
        /// </summary>
        /// <param name="guia"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosGuiaEntrado(DatosGuiaEntrada guia, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosGuiaEntrado(guia, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación y baja de los datos piso
        /// </summary>
        /// <param name="piso"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPiso(DatosPiso piso, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosPiso(piso, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, baja y modificación de los datos barandal
        /// </summary>
        /// <param name="barandal"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosBarandal(DatosBarandal barandal, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosBarandal(barandal, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos Drive In
        /// </summary>
        /// <param name="drive"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosDriveIn(DatosDriveIn drive, int intCotizacionID, int intDetCotizaID, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                Cotizacion detCotizacion = new Cotizacion();
                detCotizacion.intCotizacionID = intCotizacionID;
                detCotizacion.intDetCotizaID = intDetCotizaID;
                detCotizacion.intElementoID = 32;
                detCotizacion.intPartida = 0;
                detCotizacion.intCantidad = 0;
                detCotizacion.decMonto = 0;
                detCotizacion.decSubtotal = 0;

                // Almacenamos el registro
                result = (new CotizacionLogic()).setDetCotizacion(detCotizacion, (short)(intDetCotizaID == 0 ? 1 : tinOpcion));
                if (result.vchResultado != "NOK")
                {
                    intDetCotizaID = Convert.ToInt32(result.vchResultado);
                    drive.intDetCotizaID = intDetCotizaID;

                    List<DatosDriveIn> ListDrive = new List<DatosDriveIn>();
                    DatosDriveIn _drive = new DatosDriveIn();

                    // Validamos si es un nuevo registro
                    if (tinOpcion != 1)
                        ListDrive = ListarDatosDriveIn((int)drive.intDatosDriveInID, intCotizacionID);
                    // Validamos si existe registro
                    if (ListDrive.Count() > 0)
                        _drive = ListDrive.First();
                    else
                        _drive.intDatosDriveInID = 0;
                    // Actualizamos la información
                    _drive.bitActivo = drive.bitActivo;
                    _drive.bitDobleMonten = drive.bitDobleMonten;
                    _drive.bitEsEstructural = drive.bitEsEstructural;
                    _drive.decAltura = drive.decAltura;
                    _drive.decAlturaCanastilla = drive.decAlturaCanastilla;
                    _drive.decAlturaMaxima = drive.decAlturaMaxima;
                    _drive.decAnchoMonta = drive.decAnchoMonta;
                    _drive.decCapacidadMaxima = drive.decCapacidadMaxima;
                    _drive.decFondo = drive.decFondo;
                    _drive.decFrente = drive.decFrente;
                    _drive.decPeso = drive.decPeso;
                    _drive.intDetCotizaID = intDetCotizaID;
                    _drive.intElementoID = 32;
                    _drive.sintPinturaID = drive.sintPinturaID;
                    _drive.sintMaterialDriveInID = drive.sintMaterialDriveInID;

                    //Realizamos el registro del DRIVEIN
                    result = DriveInDA.setDatosDriveIn(_drive, tinOpcion);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que realiza el alta, baja y modificación de los datos poste
        /// </summary>
        /// <param name="poste"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosPosteDriveIn(DatosPosteDriveIn poste, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = DriveInDA.setDatosPosteDriveIn(poste, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos de DriveIn
        /// </summary>
        /// <param name="intDatosDriveInID"></param>
        /// <param name="intCotizacionID"></param>
        /// <returns></returns>
        public List<DatosDriveIn> ListarDatosDriveIn(int intDatosDriveInID, int intCotizacionID)
        {
            List<DatosDriveIn> result = new List<DatosDriveIn>();
            try
            {
                result = DriveInDA.ListarDatosDriveIn(intDatosDriveInID, intCotizacionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Procedimiento que lista los datos Drive In en base al tipo de viga
        /// </summary>
        /// <param name="sintTipoVigaID"></param>
        /// <param name="sintLongitudID"></param>
        /// <param name="intCalibreID"></param>
        /// <param name="sintLargoID"></param>
        /// <returns></returns>
        public List<DriveIn> ListarDatosMstDriveIn(short sintTipoVigaID, short sintLongitudID, int intCalibreID, short sintLargoID)
        {
            List<DriveIn> result = new List<DriveIn>();
            try
            {
                result = DriveInDA.ListarDatosMstDriveIn(sintTipoVigaID, sintLongitudID, intCalibreID, sintLargoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
