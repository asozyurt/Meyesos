using System;
using System.ServiceModel;
using Umbiad.App.Service.Meyesos;

namespace Umbiad.App.HostApplication
{
    class Program
    {
        public static void Main(string[] args)
        {

            ServiceHost svcHost = null;
            try
            {
                svcHost = new ServiceHost(typeof(MessageService));
                svcHost.Open();

                Console.WriteLine("\n\nService is Running  at following address");
                Console.WriteLine("\nhttp://localhost:9001/MessageService");
                Console.WriteLine("\nnet.tcp://localhost:9002/MessageService");
            }
            catch (Exception eX)
            {
                svcHost = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + eX.Message + "]");
                Console.ReadKey();
            } if (svcHost != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcHost.Close();
                svcHost = null;
            }
        }
    }
}
