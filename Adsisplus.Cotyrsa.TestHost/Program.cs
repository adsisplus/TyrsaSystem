using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Adsisplus.Cotyrsa.Services.DireccionService;
using Adsisplus.Cotyrsa.Services.EmpresaService;
using Adsisplus.Cotyrsa.Services.PersonaService;

namespace Adsisplus.Cotyrsa.TestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*************************Adsisplus.Seguridad.Services Versión 0.1.0****************************");
                Console.WriteLine("Iniciando servicios...");
                Console.WriteLine();

                using (ServiceHost host1 = new ServiceHost(typeof(DireccionServices)))
                {
                    host1.Open();
                    Console.WriteLine("Servicio DireccionServices Iniciado!");
                    Console.WriteLine();

                    using (ServiceHost host2 = new ServiceHost(typeof(EmpresaServices)))
                    {
                        host2.Open();
                        Console.WriteLine("Servicio EmpresaServices Iniciado!");
                        Console.WriteLine();

                        using (ServiceHost host3 = new ServiceHost(typeof(PersonaServices)))
                        {
                            host3.Open();
                            Console.WriteLine("Servicio PersonaServices Iniciado!");
                            Console.WriteLine();

                            Console.ReadKey();

                            host1.Close();
                            host2.Close();
                            host3.Close();
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al iniciar servicios:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para terminar...");
                Console.ReadKey();
            }
        }
    }
}
