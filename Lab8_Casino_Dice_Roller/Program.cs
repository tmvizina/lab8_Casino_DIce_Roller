using System;

namespace Lab8_Casino_Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Would you like to roll?");

                string RollGoAhead = Console.ReadLine().ToLower();

                if (RollGoAhead == "yes")
                {
                    Console.WriteLine("How many sides of dice would you like?");
                    int NumofSides = int.Parse(Console.ReadLine());

                    int roll1 = RandomDice(NumofSides);
                    int roll2 = RandomDice(NumofSides);
                    int total = roll1 + roll2;

                    if (NumofSides == 6)
                    {
                        string specialmsg = SpecialCaseCheck(roll1, roll2, total);
                        Console.WriteLine(specialmsg);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine($"First Roll is {roll1}");
                        Console.WriteLine($"Second Roll is {roll2}");
                        Console.WriteLine($"Total is {total}");
                    }
                    else
                    {
                        Console.WriteLine($"First Roll is {roll1}");
                        Console.WriteLine($"Second Roll is {roll2}");
                        Console.WriteLine($"Total is {total}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("What a shame maybe next time! Goodybe!");
                    goOn = false;
                }

            }
        
        }


        public static string SpecialCaseCheck(int roll1, int roll2,int total)
        {
            if (roll1 == 1 && roll2 == 1)
            {
                string snake = "Snake Eyes";
                return snake;
            }
            else if (roll1 == 1 && roll2 == 2 || roll1==2&&roll2==1)
            {
                string aceduece = "Ace Deuces";
                return aceduece;
            }
            else if (roll1==6&&roll2==6)
            {
                string boxcar = "Box Cars";
                return boxcar;
            }
            else if (total==7||total==11)
            {
                string win = "Win!";
                return win;
            }
            else if (total==2||total==3||total==12)
            {
                string craps = "Craps! WOMP WOMP WOMP";
                return craps;
            }
            else
            {
                string notspecial = "";
                return notspecial;
            }


        }

        public static int RandomDice(int NumofSides)
        {
            Random r = new Random();
       
          
            int roll = r.Next(1, NumofSides+1);

            return roll;
        }
    }
}
