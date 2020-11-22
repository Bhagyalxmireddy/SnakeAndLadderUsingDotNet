using System;

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
       public static int PLAYER1 = 0;
       public static int PLAYER2 = 0;
       public static String action;
       public static int diceCount = 0;
       public  static int numOfPlayers = 2;
       public static int[] playerArray = new int[numOfPlayers];
            public static void playerPosition()
            {
                for(int i = 0;i < playerArray.Length; i++)
                {
                    playerArray[i] = STARTINGPOSITION;
                }
            }


        public static void gameplayed()
             {
                int position = STARTINGPOSITION;
                for(int i = 0; i < playerArray.Length; i++)
                {
                    Console.WriteLine("welcome to Two player game");
                    Console.WriteLine("Player is: " + (i + 1));                                       
                        Random random = new Random();
                        int dice = (random.Next(0, 6) + 1);
                        Console.WriteLine("The Dice value is : " + dice);
                        diceCount++;
                        int options = random.Next(0, 3);
                        switch (options)
                        {
                            case 1:
                                action = "Ladder";
                                int currentPosition = playerArray[i] + dice;
                                 if (currentPosition > ENDINGPOSITION)
                                {
                                    Console.WriteLine("The Player Position is more than 100 so player is stay in the same position");
                                 }
                                else
                                {
                                    playerArray[i] = currentPosition;
                                    if(playerArray[i] != ENDINGPOSITION)
                                    {
                                        gameplayed();
                                    }
                                }
                            break;
                            case 2:
                                action = "Snake";
                                position = playerArray[i] - dice;
                                playerArray[i] = position;                                
                                if(playerArray[i] < 0)
                                {
                                    playerArray[i] = 0;
                                }
                            break;
                            case 0:
                                action = "NoPlay";
                                position = position;
                            break;
                        }
                        Console.WriteLine("Dice value is : " + dice + " For " + action + " and the Current position is : " + playerArray[i]);                                     
                }
             }
        public static void trunOfPlayer()
        {
            playerPosition();
            int gameposition = 0;
            while(gameposition != 1)
            {
                for (int i = 0; i < playerArray.Length; i++)
                {
                    Console.WriteLine("The Player is :" + (i + 1));
                    gameplayed();
                    if(playerArray[i] == ENDINGPOSITION)
                    {
                        gameposition = 1;
                        Console.WriteLine("Player:" + (i + 1) + "Won the Game");
                        break;
                    }
                }
            }
            for (int i = 0; i < numOfPlayers; i++)
            {
                Console.WriteLine("Player:" + (i + 1) + "and the position is " + playerArray[i]);
            }
            Console.WriteLine("The DiceCount value of players is:" + diceCount);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder Program");
            gameplayed();
            playerPosition();
            trunOfPlayer();
        }
    }
}
