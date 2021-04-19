using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business
{
    class MernisUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response=client.TCKimlikNoDogrulaAsync(32638672298, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear);
            
            response.Wait();
            bool result=(response.Result.Body.TCKimlikNoDogrulaResult) ? true:  false;
            return result;
 
        }
    }
}
