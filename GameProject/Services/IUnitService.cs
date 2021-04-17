using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Services
{
    interface IUnitService
    {
        void Add(Unit unit);
        void Add(List<Unit> Units);
        void Update(Unit Unit);
        void Delete(Unit Unit);
        //void GetAllUnits();
    }
}
