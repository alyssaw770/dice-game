namespace DiceGameApp;

class Program
{
    static void Main(string[] args)
    {

        int playerRandomRoll;
        int computerRandomRoll;
        int playerScore = 0;
        int computerScore = 0;

        Random random = new Random();


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Press any key to roll the dice.");

            Console.ReadKey(true);

            playerRandomRoll = random.Next(1, 7);
            Console.WriteLine("You rolled " + playerRandomRoll);

            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);

            computerRandomRoll = random.Next(1, 7);
            Console.WriteLine("The computer rolled " + computerRandomRoll);

            if (playerRandomRoll > computerRandomRoll)
            {
                playerScore++;
                Console.WriteLine("You won this round!");
                Console.WriteLine("");

            }
            else if (playerRandomRoll < computerRandomRoll)
            {
                computerScore++;
                Console.WriteLine("You lost this round!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("It's a draw!");
                Console.WriteLine("");

            }

        }
            Console.WriteLine("");
            if(playerScore > computerScore)
            {
                Console.WriteLine("You won the game!");
            }
            else if(playerScore < computerScore)
            {
                Console.WriteLine("You lost the game!");
            }
            else
            {
                Console.WriteLine("The game ended in a draw.");
            }
        
        Console.ReadKey();
    }
}

