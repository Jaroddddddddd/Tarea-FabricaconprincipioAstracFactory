using System;
using TareaFactori.Interfaces;

namespace TareaFactori.Clases
{
    public class Dellisperon15300: ISupremoComputer
    {
        public Dellisperon15300()
        {
        }

        public string GetModelDetails()
        {
            return "Modelo: Dell isperon 15300\nRAM: 16GB\nDisco Duro: 1500GB\nTarjeta Grafica: GTX1060\n";
        }
    }
}
