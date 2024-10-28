using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perudo.Core
{
    public class PlayerBase
    {
        public bool LostLastRound { get; set; } // Игрок проиграл предыдущий раунд
        public int PlayerId { get; set; } // ID игрока в игре
        public List<Dice> Dices { get; set; } = new List<Dice>();

        public PlayerBase() 
        {
            this.TakeDices();
        }

        private void TakeDices()
        {
            for (int i = 0; i < 5; i++)
            {
                Dices.Add(new Dice());
            }
        }

        // Перемешать кубики игрока
        public void ShakeDices()
        {
            foreach (Dice d in Dices)
            {
                d.Shake();
            }
        }

        // Метод для получения следующего хода
        public virtual Step MakeStep(Step lastStep)
        {
            // Реализация метода должна быть определена в наследуемом классе
            throw new NotImplementedException("Метод GetStep не реализован.");
        }
    }

    // Здесь должны быть описаны классы наследники для разных типов игроков
}
