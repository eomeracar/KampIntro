using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Services
{
    interface IStockService
    {
        //Too many functions must be implemented and no need for rn.
        void Add(Stock stock);
        void Add(List<Stock> stocks);
        void Update(Stock stock);
       // void Update(List<Stock> stocks);
        void Delete(Stock stock);
       // void Delete(List<Stock> stocks);

    }
}
