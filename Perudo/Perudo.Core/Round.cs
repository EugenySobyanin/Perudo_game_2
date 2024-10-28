using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perudo.Core
{
    public class Round
    {
        static int RoundNumber = 0;
        public Round(List<PlayerBase> players)
        {
            Players = players;
            RoundNumber += 1;
            this.GetPlayersId();
        }

        public List<PlayerBase> Players { get; set; } // Список игроков
        Step LastStep { get; set; } // Последний ход
        Step CurrentStep { get; set; } // Текущий ход
        bool WinRound   { get; set; } = false; // Есть победитель раунда или нет
        List<int> playersId = new List<int>(); // Id игроков, которые учавствуют в раунде

        private void GetPlayersId()
        {
            foreach (PlayerBase player in Players)
            {
                playersId.Add(player.PlayerId);
            }
        }

        public void SimulateRound()
        {
            while (!WinRound)
            {
                // Первым ходит тот кто проиграл предыдущий раунд
                int current_player_id;
                if (RoundNumber == 1) current_player_id = 1;
                else
                {
                    foreach (PlayerBase player in Players)
                    {
                        if (player.LostLastRound)
                        {
                            current_player_id = player.PlayerId;
                            break;
                        } 
                    }
                    // дальше игроки должны по очереди делать ход, надо придумать как это
                }

            }

        }
    }
}
