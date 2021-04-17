using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage credit payment plan is calculated");
        }

        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }
}
