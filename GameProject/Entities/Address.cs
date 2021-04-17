using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    //We wiil be using only the prop Detail,it will be like summary.
    //Cause for all the Ids such as CountryId,CountyId,DisctrictId, etc. does not have any entity that are created before. 
    
    class Address:IEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CountyId { get; set; }
        public int DistrictId { get; set; }
        public string Detail { get; set; }
    }
}
