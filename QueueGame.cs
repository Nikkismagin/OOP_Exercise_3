using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public class QueueGame
    {
        private static List<GameInterface> games;
        public QueueGame()
        {
            games = new List<GameInterface>();
        }
        // добавить игру в очередь
        public void AddGame(GameInterface game)
        {
            games.Add(game);
        }
        // извлечь игру из очереди
        public GameInterface GetGame()
        {
            int index = 0;
            GameInterface game = games[index];
            games.RemoveAt(index);
            return game;
        }
        // вывести список всех игр
        public override string ToString()
        {
            string str = "";
            foreach (GameInterface game in games)
            {
                str += game + "\n";
            }
            return str;
        }
        // количество игр в очереди
        public int countGame()
        {
            return games.Count;
        }
    }
}
