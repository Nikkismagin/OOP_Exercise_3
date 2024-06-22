using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public class GamesApp
    {
        private static List<Player> gamers;
        private static List<GameInterface> games;
        public GamesApp()
        {
            gamers = new List<Player>();
        }
        public bool auth(string username, string password)
        {
            return true;
        }
        public bool registr(string username, string password)
        {
            gamers.Add(new Player(username));
            return true;
        }
        public void addGame(GameInterface game)
        {
            games.Add(game);
        }
        public void beginGamesApp()
        {
            auth("admin", "admin");
        }
    }
}
