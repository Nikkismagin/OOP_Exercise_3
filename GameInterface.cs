using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public interface GameInterface
    {
        void startGame(); // Начинает игру
        string getGameName(); // Возвращает название игры
        bool isWin(); // Возвращает результаты игры
    }
}
