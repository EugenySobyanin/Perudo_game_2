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
        public List<int> DicesValues { get; set; } = new List<int>(); // хранит значение кубиков в текущем раунде

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

        // Получить значение своих кубиков в определенном раунде
        public void GetDicesValues()
        {
            foreach (Dice d in Dices)
            {
                DicesValues.Add(d.Value);
            }
        }

        // Метод для получения следующего хода
        public virtual Step MakeStep(Step lastStep)
        {
            // Реализация метода должна быть определена в наследуемом классе
            throw new NotImplementedException("Метод GetStep не реализован.");
        }

        // Метод для первого хода
        public virtual Step FirstStep()
        {
            throw new NotImplementedException("Метод FirstStep не реализован");
        }

        // Здесь должны быть описаны классы наследники для разных типов игроков

        /*Игрок - новичок, аккуратно повышает, не блефует, проверяет большие значения
         Это самая простая стратегия*/
        public class ConservativePlayer : PlayerBase
        {
            public override Step MakeStep(Step last_step, int sum_dices, int players_count)
            {
                if (last_step == null)
                {

                }
            }

            public override Step FirstStep() 
            {

            }
        }
    }
}
