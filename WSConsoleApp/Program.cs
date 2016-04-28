using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSConsoleApp.WSPReference;

namespace WSConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient client = new WebService1SoapClient();
            Console.WriteLine(client.HelloWorld());
            Console.Read();
        }
    }
}
