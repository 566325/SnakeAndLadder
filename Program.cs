using System.Security.Cryptography.X509Certificates;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SinglePlayer Game= new SinglePlayer();
            //Game.Start();
            PlayerRollsDie Game= new PlayerRollsDie();
            Game.Start();


            //Random random = new Random();
            //int Count = random.Next(1, 6);
        }

    }
}