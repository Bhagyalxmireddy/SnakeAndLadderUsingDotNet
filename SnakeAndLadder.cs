using System;

namespace SnakeAndLadderProgram
{
    class SnakeAndLadder
    {
         int STARTINGPOSITION = 0;
         int LADDER = 1;
         int SNAKE = 2;
         int PLAYER = 0;
            public static void gameplayed()
             {
                Console.WriteLine("welcome to single player game");
                Random random = new Random();
                int dice = (random.Next(0, 6) + 1);
                Console.WriteLine("The Dice value is : " + dice);
             }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder Program");
            gameplayed();
        }
    }
}
