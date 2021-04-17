using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(mortgageCreditManager); 
            Console.WriteLine("Hello World!");

            List<ICreditManager> credits = new List<ICreditManager> { personalFinanceCreditManager };
            

            applicationManager.MakeCreditPreInformation(credits);

        }
    }
}
