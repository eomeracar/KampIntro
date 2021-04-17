using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance credit payment plan is calculated");
        }

        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
        public void Add(ICreditManager creditManager)
        {
            
        }
    }
}
