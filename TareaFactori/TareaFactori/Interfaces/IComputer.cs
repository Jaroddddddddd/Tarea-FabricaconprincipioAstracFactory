using System;
namespace TareaFactori.Interfaces
{
    public interface IComputer
    {
        ISupremoComputer GetSupremoComputer();
        INormalComputer GetNormalComputer();
    }
}
