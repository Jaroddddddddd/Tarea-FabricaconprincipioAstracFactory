using System;
using TareaFactori.Interfaces;

namespace TareaFactori.Clases
{
    public class LenovoZ580: INormalComputer
    {
        public LenovoZ580()
        {
        }

        public string GetModelDetails()
        {
            return "Modelo:Lenovo Z580\nRAM: 4GB\nDisco Duro: 500GB\nTarjeta Grafica: GTX1030\n";
        }
    }
}
