using System;
using TareaFactori.Interfaces;

namespace TareaFactori.Clases
{
    public class Lenovoideapad:ISupremoComputer
    {
        public Lenovoideapad()
        {
        }

        public string GetModelDetails()
        {
            return "Modelo:Lenovo ideapad\nRAM: 6GB\nDisco Duro: 500GB\nTarjeta Grafica: GTX1040\n";
        }
    }
}
