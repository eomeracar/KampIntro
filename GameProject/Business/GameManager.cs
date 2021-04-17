using GameProject.Entities;
using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business
{
    class GameManager : IGameService
    {
        List<Game> _game;
        public GameManager()
        {
            _game = new List<Game>();
        }
        public void Add(Game game)
        {
            _game.Add(game);
        }

        public List<Game> GetGames()
        {
            return _game;
        }
    }
}
