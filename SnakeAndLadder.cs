﻿using System;

namespace SnakeAndLadderProgram
{
    class SnakeAndLadder
    {
       public static int STARTINGPOSITION = 0;
       public static int ENDINGPOSITION = 100;
       public static int LADDER = 1;
       public static int SNAKE = 2;
       public static int NOPLAY = 0;
       public static int PLAYER = 0;
       public static String Action;
            public static void gameplayed()
             {
                int position = STARTINGPOSITION;
                if (position <= ENDINGPOSITION)
                {
                    Console.WriteLine("welcome to single player game");
                    Random random = new Random();
                    int dice = (random.Next(0, 6) + 1);
                    Console.WriteLine("The Dice value is : " + dice);
                    int options = random.Next(0, 3);
                    switch (options)
                    {
                    case 1:
                        Action = "Ladder";
                        position = position + dice;
                        break;
                    case 2:
                        Action = "Snake";
                        position = position - dice;
                        break;
                    case 3:
                        Action = " NoPlay";
                        position = position;
                        break;
                     }
                Console.WriteLine("Dice value is : " + dice + " For " + Action + " and the Current position is : " + position);
                }
             }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder Program");
            gameplayed();
        }
    }
}
