using System;
using System.IO;
using static System.Console;


//This program calculates batting averages for player 1 through 12 and reads a column from a txt file.
//Author: Heather Whittlesey  8/23/20
//implicit conversion will allow small data to big data but not big data to small data 
//- truncation could occur therfore is not allowed

namespace BaseballScores
{
    class playBall3
    {
        private static int playerId;
        private static int hits;
        private static int bats;

        static string[] playerArray = new string[12]; 
                                                      
        static double[,] statData = new double[12, 3];//2-d array

        static void Main()
        {
            
            Init();

            int options;
            Boolean inValid = false;
            
            while (!inValid)
            {
                options = MenuOptions();
                switch (options)
                {
                    case 1:
                        playerId = PlayerNo();
                        Calc();                     
                        break;
                    case 2:
                        StreamWriter();
                        break;
                    case 3:                                            
                        inValid = true;
                        break;
                    default:
                        Console.WriteLine("An Error occurred. Please try again.");
                        break;
                }
            }
        }


        public static void Init()
        {
            
            int[] playArray = new int[12];
            string recordIn;
            const string FILENAME = "BaseballAvg.txt";
            FileStream inFile = new FileStream(FILENAME,
            FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

           
            //opening and reading file ^^^

            {
               for (int p = 0; p < playerArray.Length; p++)
                {
                    playerArray[p] = reader.ReadLine(); // this is what prints to the console                   
                }

                for (int p = 0; p < 12; p++)
                {
                    statData[p, 0] = 0;
                    statData[p, 1] = 0;
                    statData[p, 2] = 0;

            //initializing the 2-d array to zero ^^^
                }
                
                recordIn = reader.ReadLine();
                
            }                     
            reader.Close();
            inFile.Close();           
        }

        public static void StreamWriter()
        {
            WriteLine("\n{0,-20}{1,-2}{2,9}{3,12}\n",
               "Player Name", "Bats", "Hits", "Average");

            for (int p = 0; p < playerArray.Length; p++) ;

            for (int p = 0; p < playerArray.Length; p++)

            {
                WriteLine("\n{0,-20}{1,-2}{2,9}{3,12}\n",
            playerArray[p], statData[p, 0], statData[p, 1], statData[p, 2].ToString("F3"));

            //formatting and printing to the console ^^^
            }
        }

        public static double BatInfo()
        {
            bats = 0;
            double convertBats;
            string iData;

            Boolean inValid = true;

            while (inValid)
            {
                Console.Write("Choose how many bats the player had :");
                iData = Console.ReadLine();
                try
                {
                    bats = int.Parse(iData);
                    convertBats = Convert.ToDouble(bats);
                }
                catch (Exception e)
                {
                    Console.Write("Please enter a whole number.");
               
                }            

                if (inValid)
                  
                    statData[playerId - 1, 0] = statData[playerId - 1, 0] + bats; 
                    // this is what accumulates your bats for you ^^^

                inValid = false;


                if (bats >= 1) 
                {
                    Console.WriteLine("Bats acceptable.");                 
                    break;
                }

                else
                {
                    Console.WriteLine("Bats must be greater than zero.");
                    inValid = true;
                }

            }
            return bats;
        }


        public static double HitInfo()
        {
            hits = 0;
            double convertHits;
            string iData;

            Boolean inValid = true;

            while (inValid)
            {
                Console.Write("Choose how many hits the player had :");
                iData = Console.ReadLine();
                try
                {
                    hits = int.Parse(iData);
                    convertHits = Convert.ToDouble(hits);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a whole number :");
                }

                if (hits > bats)
                {
                    Console.WriteLine("Hits must be less than bats.");
                    inValid = false;

                }
                else
                {
                    Console.WriteLine("Bats/Hits Acceptable");
                }
                if (inValid)

                   

                if (hits >= 0)
                    {
                        Console.WriteLine("Hits acceptable.");
                        statData[playerId - 1, 1] = statData[playerId - 1, 1] + hits;
                        // this accumulates the hits ^^^
                        inValid = false;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Hits must be greater than zero.");
                        hits = 0; // this keeps neg numbers from entering table                                             
                    } 
                
               
            }
            return hits;
        }



        public static void Calc()

        {
             double bats = BatInfo();  
             double hits = HitInfo();
           
             double avg2 = statData[playerId - 1, 1] / statData[playerId - 1, 0];
               
             statData[playerId - 1, 2] = avg2;           
        }

        class Players
            {
                public string PlayerName { get; set; }
                public int PlayerBats { get; set; }
                public int PlayerHits { get; set; }
            }

            public static int MenuOptions()
            {
                int options = 0;
                Boolean inValid = true;

                while (inValid)
                {
                    Console.Write("Enter 1 for insert player statistics or enter 2 to see a display of player statistics or enter 3 to quit program. ");
                    options = Convert.ToInt32(Console.ReadLine());

                    if (options > 0 && options <= 3)
                    {
                        Console.Write("That entry is acceptable.\n");
                        break;
                    }
                    else
                    {
                        Console.Write("Please enter a 1, 2 or 3.\n");
                        bats = 0;
                    }
                }
                return options;
            }

            public static int PlayerNo()

            {
                int playerId = 0;
                Boolean inValid = true;
                string iData;

                while (inValid)
                {
                    Console.WriteLine("Please Enter the Player Id: 1 through 12: ");
                    iData = Console.ReadLine();
                    try
                    {
                        playerId = Convert.ToInt32(iData);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Player Id is unacceptable.");
                    }
                    if (playerId > 0 && playerId < 13)
                    {
                        Console.WriteLine("Player Id is acceptable.");
                        break;
                    }
                }
            return playerId;
            }
        }
    }

