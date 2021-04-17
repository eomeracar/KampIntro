using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager)
        {
            //
            creditManager.Calculate();
        }
        public void MakeCreditPreInformation(List<ICreditManager> creditManager)
        {
            foreach (var credit in creditManager)
            {
                credit.Calculate();
            }
        }
    }
}
