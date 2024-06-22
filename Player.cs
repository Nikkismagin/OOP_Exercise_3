using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    [Serializable]
    public class Player
    {
        // имя игрока
        private string playerName;
        private int id;
        // очередь из игр
        private QueueGame queueGame;
        // результаты игр
        private Dictionary<string, int[]> gameResult;
        // "угадай число" 2, 3

        public Player(string PlayerName)
        {
            this.playerName = PlayerName;
            this.queueGame = new QueueGame();
            this.gameResult = new Dictionary<string, int[]>();
        }

        public override string ToString()
        {
            return $"Gamer: {this.playerName}";
        }

        public void Play()
        {
            if (queueGame.countGame() != 0)
            {
                GameInterface game = queueGame.GetGame();
                game.startGame();
                bool result = game.isWin();
                updateStatistics(game.getGameName(), result);
            }
        }

        public void updateStatistics(string gameName, bool result)
        {
            if (!this.gameResult.ContainsKey(gameName))
            {
                if (result)
                {
                    this.gameResult.Add(gameName, new int[] { 1, 0 });
                }
                else
                {
                    this.gameResult.Add(gameName, new int[] { 0, 1 });
                }
            }
            else
            {
                if (result)
                {
                    this.gameResult[gameName][0]++;
                }
                else
                {
                    this.gameResult[playerName][1]++;
                }
            }
        }

        public void addGameToQueueGamer(GameInterface game)
        {
            this.queueGame.AddGame(game);
        }

        public string getStatistics(String gameName)
        {
            return $"побед: {this.gameResult[gameName][0]} поражений: {this.gameResult[gameName][1]}";
        }
        public string getStatistics()
        {
            string result = "";
            foreach (var game in gameResult)
            {
                result += $"{game.Key} побед: {game.Value[0]} поражений: {game.Value[1]} \n";
            }
            return result;
        }

        public int getCountGames()
        {
            return gameResult.Count;
        }
    }
}
