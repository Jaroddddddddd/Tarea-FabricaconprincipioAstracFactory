using System;
using TareaFactori.Interfaces;

namespace TareaFactori.Clases
{
    public class Dellisperon15200: INormalComputer
    {
        public Dellisperon15200()
        {
        }

        public string GetModelDetails()
        {
            return "Modelo: Dell isperon 15200\nRAM: 8GB\nDisco Duro: 1000GB\nTarjeta Grafica: GTX1050\n";
        }
    }
}
