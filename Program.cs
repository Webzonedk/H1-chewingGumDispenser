using System;
using System.Collections.Generic;
using System.Threading;

namespace chewingGumDispenser
{
    class Program
    {
        private static Dispenser dispenser = new Dispenser();
        static void Main(string[] args)
        {
            //Console.WriteLine("====================================");
            //Console.WriteLine("Welcome to the Chewing gum dispenser");
            //Console.WriteLine("====================================");
            //call the addgum Dispenser.add()
            dispenser.CalculateGums();
            dispenser.AddGum();
            bool quit = false;
            while (quit == false)
            {
                Console.Clear();
            Console.WriteLine("====================================");
                Console.WriteLine("Welcome to the Chewing gum dispenser");
            Console.WriteLine("====================================");
                Console.WriteLine($"total amount= {dispenser.gums.Count}");
                Console.WriteLine();
                Console.WriteLine("Turn the handle to get a cheewing gum");
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
                    }
                    else
                    {
                    Console.WriteLine($"You got a {luckyGum.Taste}");
                        Thread.Sleep(10);
                    }
                }
                else
                {
                    quit = true;

                }
              
                //Console.WriteLine("Press 1: to turn the handle again | Press 2 to exit without another gum");
                //if (dispenser.Choose() == false)
                //{
                //    quit = true;  //call the removeGum Dispenser.remove()
                //}
            }
        }

    //    private static void createDispenser()
    //    {
    //                Dispenser dispenser = new Dispenser();

    //}


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
