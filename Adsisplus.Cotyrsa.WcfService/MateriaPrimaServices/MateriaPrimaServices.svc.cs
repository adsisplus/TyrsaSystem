using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Adsisplus.Cotyrsa.BusinessEntities;
using Adsisplus.Cotyrsa.BusinessLogic;

namespace Adsisplus.Cotyrsa.WcfService.MateriaPrimaServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MateriaPrimaServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MateriaPrimaServices.svc o MateriaPrimaServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MateriaPrimaServices : IMateriaPrimaServices
    {
        /// <summary>
        /// Procedimiento que realiza el alta, modificación o baja de un producto acero
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="sintOpcion"></param>
        /// <returns></returns>
        public Resultado setProductoAcero(ProductoAcero producto, short sintOpcion)
        {
            Resultado result = new Resultado();
            try
            {
                result = (new MateriaPrimaLogic()).setProductoAcero(producto, sintOpcion);
            }
            catch (Exception ex)
            {
                Adsisplus.Cotyrsa.BusinessLogic.EventLogManager.LogErrorEntry(ex.Message);
            }
            return result;
        }
    }
}
