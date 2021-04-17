using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using RestSharp;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer _gamer)
        {
            //for now
            if(_gamer.BirthYear == 1995  && _gamer.FirstName=="Ömer" && _gamer.LastName=="Acar" 
                && _gamer.IdentityNumber==12345678901)
            {
                return true;
            }
            return false;
        }
    }
}
