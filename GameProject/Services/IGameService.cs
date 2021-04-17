using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Services
{
    interface IGameService
    {
        void Add(Game game);
        List<Game> GetGames();
    }
}
