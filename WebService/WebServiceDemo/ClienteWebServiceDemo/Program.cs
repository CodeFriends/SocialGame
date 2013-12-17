using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWebServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar serviço
            WebServiceDemoNS.ServiceDemoClient proxy =
            new WebServiceDemoNS.ServiceDemoClient();
            //chamar método Add do serviço
            int resultado = proxy.Add(3, 5);
            System.Console.WriteLine(resultado);
        }
    }
}
