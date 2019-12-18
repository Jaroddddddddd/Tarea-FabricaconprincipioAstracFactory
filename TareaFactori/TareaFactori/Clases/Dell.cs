using System;
using TareaFactori.Interfaces;

namespace TareaFactori.Clases
{
    public class Dell: IComputer
    {
        public Dell()
        {
        }

        public INormalComputer GetNormalComputer()
        {
            return new Dellisperon15200();
        }

        public ISupremoComputer GetSupremoComputer()
        {
            return new Dellisperon15300();
        }
    }
}
