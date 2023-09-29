using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class CheckTheDieThrown
    {
        public void Start()
        {
            int Player_Position;
            int PlayerOne = 0;
            int checkWin;
            Console.WriteLine("Player One position is {0} " , PlayerOne);
            while (PlayerOne <= 100)
            {
                checkWin = CheckWin(PlayerOne);

                if (checkWin == 1)
                {
                    Console.WriteLine("PlayerOne wins");
                    break;
                }
                if (checkWin == 2)
                {
                    Player_Position = 0;
                }
                else
                {
                    Player_Position = RollsDie();
                }
                if (Player_Position == 0)
                {
                    Console.WriteLine("its is No play");
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
                if (PlayerOne > 100)
                {
                    PlayerOne -= Player_Position;
                }
                Console.WriteLine("player One rolls die and get position {0} " , PlayerOne);

            }
            Console.WriteLine("Number of Times Dice Thrown: {0}", diceThrown);
        }
        public int CheckWin(int PlayerOne)
        {
            if (PlayerOne == 100)
                return 1;
            if (PlayerOne > 100)
                return 2;
            else
                return 0;
        }
        readonly Random random = new Random();

        int diceThrown = 0;
        public int RollsDie()
        {

            int dice, check;
            dice = random.Next(1, 7);
            diceThrown++;
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
