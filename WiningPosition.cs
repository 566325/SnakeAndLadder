using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class WiningPosition
    {
        public void Start()
        {
            int Player_Position;
            int PlayerOne = 0;
            Console.WriteLine("Player One position is " + PlayerOne);
            while (PlayerOne <= 100)
            {
                Player_Position = RollsDie();
                if (Player_Position == 0)
                {
                    Console.WriteLine("He is No play");
                    PlayerOne += Player_Position;
                }
                if (PlayerOne == 0 && Player_Position < 0)
                {
                    Console.WriteLine("its a snake bite ");
                    PlayerOne = 0;
                }
                if (PlayerOne > 0 && Player_Position < 0)
                {
                    Console.WriteLine("its a snake bite");
                    PlayerOne += Player_Position;
                    if (PlayerOne < 0)
                    {

                        PlayerOne = 0;
                    }
                }
                if (Player_Position > 0)
                {
                    Console.WriteLine("its a ladder");
                    PlayerOne += Player_Position;
                }

                Console.WriteLine("player One rolls die and get position " + PlayerOne);
            }

                
        }
        readonly Random random = new Random();
        public int RollsDie()
        {

            int dice, check;
            dice = random.Next(1, 7);
            Console.WriteLine($"Dice = {dice}");
            check = CheckPosition();

            if (check == 1)
                return -dice;
            if (check == 2)
                return dice;
            else
                return 0;
        }
        public int CheckPosition()
        {

            int check = random.Next(1, 7);
            return check;
        }
    }
}
