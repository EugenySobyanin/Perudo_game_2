using Perudo.Core;

Dice dice = new Dice();

PlayerBase player = new PlayerBase();

player.ShakeDices();

for  (int i = 0; i < 5; i++)
{
    Console.WriteLine(player.Dices[i].Value);
}