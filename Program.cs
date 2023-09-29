using System.Security.Cryptography.X509Certificates;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SinglePlayer Game= new SinglePlayer();
            //Game.Start();
            //PlayerRollsDie Game= new PlayerRollsDie();
            //Game.Start();

            //CheckPlayerPosition Check= new CheckPlayerPosition();
            //Check.Start();
            //WiningPosition winingPosition = new WiningPosition();
            //winingPosition.Start();
            //ExactWinning exactWinning = new ExactWinning();
            //exactWinning.Start();
            //CheckTheDieThrown checkTheDieThrown = new CheckTheDieThrown();
            //checkTheDieThrown.Start();
            
            GameForTwoPlayers gameForTwoPlayers = new GameForTwoPlayers();
            gameForTwoPlayers.Start();


        }

    }
}