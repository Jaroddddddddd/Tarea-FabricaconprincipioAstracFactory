using System;
using TareaFactori.Interfaces;


namespace TareaFactori.Clases
{
    public class Lenovo: IComputer
    {
        public Lenovo()
        {
        }

        public INormalComputer GetNormalComputer()
        {
            return new LenovoZ580();
        }

        public ISupremoComputer GetSupremoComputer()
        {
            return new Lenovoideapad();
        }
    }
}
