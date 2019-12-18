using System;
using TareaFactori.Interfaces;
using TareaFactori.Clases;
    

namespace TareaFactori
{
    class Program
    {
        static void Main(string[] args)
        {

            IComputer lenovocomputer = new Lenovo();
            ComputerClient lenovocliente = new ComputerClient(lenovocomputer);

            Console.WriteLine("********* Lenovo **********");
            Console.WriteLine(lenovocliente.GetSmartPhoneModelDetails());
            Console.WriteLine(lenovocliente.GetNormalPhoneModelDetails());

            IComputer dellcomputer = new Dell();
            ComputerClient dellcliente = new ComputerClient(dellcomputer);

            Console.WriteLine("******* Dell **********");
            Console.WriteLine(dellcliente.GetSmartPhoneModelDetails());
            Console.WriteLine(dellcliente.GetNormalPhoneModelDetails());

            Console.ReadKey();
        }
    }
}
