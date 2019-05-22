using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessLogic
{
    public class GastosLogic
    {
        #region Constructor

        private GastosDataAccess GastosDA;

        public GastosLogic()
        {
            GastosDA = new GastosDataAccess();
        }

        #endregion

        /// <summary>
        /// Procedimiento que devuelve los datos de la pantalla de Gastos
        /// </summary>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <returns></returns>
        public List<DatosGastos> ListarDatosPantallaGastos(int intCotizacionID, int intDetCotizaID)
        {
            List<DatosGastos> result = new List<DatosGastos>();
            try
            {
                result = GastosDA.ListarDatosPantallaGastos(intCotizacionID, intDetCotizaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de los datos de gastos
        /// </summary>
        /// <param name="flete"></param>
        /// <param name="instalacion"></param>
        /// <param name="viaticos"></param>
        /// <param name="intCotizacionID"></param>
        /// <param name="intDetCotizaID"></param>
        /// <param name="bitActivo"></param>
        /// <param name="tinOpcion"></param>
        /// <returns></returns>
        public Resultado setDatosGastos(DatosFlete flete, DatosInstalacion instalacion, DatosViaticos viaticos, int intCotizacionID, int intDetCotizaID, bool bitActivo, short tinOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = GastosDA.setDatosGastos(flete, instalacion, viaticos, intCotizacionID, intDetCotizaID, bitActivo, tinOpcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}
