using System;
using TareaFactori.Clases;
using TareaFactori.Interfaces;

namespace TareaFactori.Clases
{
    public class ComputerClient
    {
        ISupremoComputer smartPhone;
        INormalComputer normalPhone;

        public ComputerClient(IComputer factory)
        {
            smartPhone = factory.GetSupremoComputer();
            normalPhone = factory.GetNormalComputer();
        }
        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.GetModelDetails();
        }


    }
}
