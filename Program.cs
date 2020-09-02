using System;
using System.Collections.Generic;
using System.Threading;

namespace chewingGumDispenser
{
    class Program
    { //creating an object og the dispenser
      private static Dispenser dispenser = new Dispenser();
        static void Main(string[] args)
        {
            //A desperate try, to create a singleton BUT THIS BASTARD IS NOT WORKING GRRRRR!!!!!
           // Dispenser dispenser = Dispenser.unicDispenser;

            dispenser.CalculateGums();
            dispenser.AddGum();
            bool quit = false;
            while (quit == false)
            {
                Console.Clear();
                Console.WriteLine("\n====================================");
                Console.WriteLine("Welcome to the Chewing gum dispenser");
                Console.WriteLine("====================================");
                Console.WriteLine($"total amount= {dispenser.gums.Count}\n");//printing the amount left in the dispenser
                Console.WriteLine("Turn the handle to get a cheewing gum\n");
                Console.WriteLine("Pess 1: to turn the handle | Press 2 to exit without a gum");
                if (dispenser.Choose() == true)
                {
                    ChewingGum luckyGum = dispenser.RemoveGum();
                    if (luckyGum == null)//checking if the bool return is true. the ! say if it is != true
                    {
                        Console.WriteLine();
                        ShowFillDispenser();
                        dispenser.CalculateGums();
                        dispenser.AddGum();
                        Console.WriteLine();
                        Console.WriteLine("Hurray.... Your mom just got ruined. Only because of your GREED your Bastard!");
                        Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("==========================================================");
                        Console.WriteLine($"You got a {luckyGum.Color} gum, with {luckyGum.Taste} taste");
                        Console.WriteLine("==========================================================");
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    quit = true;
                }
            }
        }




        /// <summary>
        /// Just a method to display if you want to refill the dispensor or if you wish to exit
        /// </summary>
        public static void ShowFillDispenser()
        {
            if (dispenser.gums.Count == 0)
            {
                Console.WriteLine("The dispenser is empty");
                Console.WriteLine("Press 1: to fill it up | Press 2: to throw it in the garbage can and Exit");
                dispenser.Choose();
            }
        }

    }
}
