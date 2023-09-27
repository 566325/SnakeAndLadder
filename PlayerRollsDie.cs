using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class PlayerRollsDie
    {
        public void Start()
        {
            int Player_Position = 0;
            int PlayerOne;
            PlayerOne = Player_Position;
            Console.WriteLine("Player One position is " + PlayerOne);
            PlayerOne = RollsDie();
            Console.WriteLine("Player Rolles the Die To Show the Position Player Position Is " + PlayerOne) ;
        }
        public int RollsDie()
        {
            
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }

    }
}
