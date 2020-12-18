using Adsisplus.Cotyrsa.BusinessLogic;
using Adsisplus.Cotyrsa.WcfService.FormatosCotizacionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.Host.MainHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/Cotizacion/");
            ServiceHost selfHost = new ServiceHost(typeof(FormatosCotizacionService), baseAddress);
            try
            {
                // Step 5: Start the service.
                selfHost.Open();
                Console.WriteLine($"The service is ready. '{baseAddress}'");

                // Close the ServiceHost to stop the service.
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.ReadLine();
            }
            catch(Exception exception)
            {
                EventLogManager.LogErrorEntry(exception);
                Console.WriteLine(exception.Message);
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.ReadLine();
            }
            selfHost.Close();

        }

    }
}
