﻿using Adsisplus.Cotyrsa.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Services.CrossBarServices.Contract
{
    [ServiceContract]
    interface ICrossBarServices
    {
        /// <summary>
        /// Obtiene la lista de datos del panel
        /// </summary>
        /// <param name="intDatosCrossBarID"></param>
        /// <param name="intElementoID"></param>
        /// <param name="intDatoMarcoID"></param>
        /// <returns></returns>
        [OperationContract]
        List<DatosCrossBar> ListarDatosPanel(Int32 @intDatosCrossBarID, Int32 @intElementoID, Int32 @intDatoMarcoID);
    }
}
