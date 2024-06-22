using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public class Game : GameInterface
    {
        private string gameName;
        private bool win;

        public Game(string gameName)
        {
            this.gameName = gameName;
        }
        public void startGame()
        {
            Console.WriteLine($"{this.gameName} start!");
            this.win = playGame();
        }
        public bool playGame()
        {
            Console.WriteLine($"{this.gameName} playGame!");
            Random rnd = new Random();
            int result = rnd.Next(0, 3);
            if (result % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.gameName;
        }
        public string getGameName()
        {
            return this.gameName;
        }
        public bool isWin()
        {
            return this.win;
        }
    }
}
