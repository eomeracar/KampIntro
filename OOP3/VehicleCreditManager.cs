using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit payment plan is calculated");
        }

        public void DoSomeThing()
        {
            throw new NotImplementedException();

        }
    }
}
