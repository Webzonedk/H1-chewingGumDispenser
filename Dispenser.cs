using System;
using System.Collections.Generic;
using System.Text;

namespace chewingGumDispenser
{
    class Dispenser
    {
        #region Fields
        private double total = 55;
        private double blueberryRound = 4;
        private double blackBerryRound = 4;
        private double tuttiFruttiRound = 4;
        private double orangeRound = 4;
        private double strawberryRound = 4;
        private double appleRound = 4;
        private ChewingGum luckyGum;
        #endregion




        #region Properties
        public ChewingGum CreateGum(string taste, string color)
        {
            ChewingGum gum = new ChewingGum(taste, color);
            return gum;
        }
        public List<ChewingGum> gums = new List<ChewingGum>();
        public List<ChewingGum> extraGums = new List<ChewingGum>();
        public List<Dispenser> displist = new List<Dispenser>();

        public Random random = new Random();
        #endregion

        #region Constructors
        public Dispenser()
        {

        }
        #endregion


        /// <summary>
        /// Calculation method to calculate the amount of each gum to be added to the dispenser
        /// </summary>
        public void CalculateGums()
        {
            total = 55;
            double percent = 100;
            double blueBerryPercent = 25;//25%
            double blackBerryPercent = 12; //12%
            double tuttiFruttiPercent = 20;//20%
            double orangePercent = 19;//19%
            double strawberryPercent = 14; //14%
            double applePercent = 10;//10%

            double blueberry = total / percent * blueBerryPercent;
            double blackBerry = total / percent * blackBerryPercent;
            double tuttiFrutti = total / percent * tuttiFruttiPercent;
            double orange = total / percent * orangePercent;
            double strawberry = total / percent * strawberryPercent;
            double apple = total / percent * applePercent;

            blueberryRound = Math.Floor(blueberry);
            blackBerryRound = Math.Floor(blackBerry);
            tuttiFruttiRound = Math.Floor(tuttiFrutti);
            orangeRound = Math.Floor(orange);
            strawberryRound = Math.Floor(strawberry);
            appleRound = Math.Floor(apple);
        }




        /// <summary>
        /// Method to add the gum objects to the dispenser based on the calculations abov
        /// </summary>
        public void AddGum()
        {
            for (int i = 0; i < blueberryRound; i++)
            {
                gums.Add(new ChewingGum("blueberry", "blue"));
            }
            for (int i = 0; i < blackBerryRound; i++)
            {
                gums.Add(new ChewingGum("blackBerry", "purple"));
            }
            for (int i = 0; i < tuttiFruttiRound; i++)
            {
                gums.Add(new ChewingGum("tuttiFrutti", "yellow"));
            }
            for (int i = 0; i < orangeRound; i++)
            {
                gums.Add(new ChewingGum("orange", "orange"));
            }
            for (int i = 0; i < strawberryRound; i++)
            {
                gums.Add(new ChewingGum("strawberry", "red"));
            }
            for (int i = 0; i < appleRound; i++)
            {
                gums.Add(new ChewingGum("apple", "green"));
            }
            //adding gum objects to the extraGumslist to use by the random to add additional gums if the dispenser is not full by the rounded amount of gums
            extraGums.Add(new ChewingGum("blueberry", "blue"));
            extraGums.Add(new ChewingGum("blackBerry", "purple"));
            extraGums.Add(new ChewingGum("tuttiFrutti", "yellow"));
            extraGums.Add(new ChewingGum("orange", "orange"));
            extraGums.Add(new ChewingGum("strawberry", "red"));
            extraGums.Add(new ChewingGum("apple", "green"));

            int addExtra = Convert.ToInt32(total - gums.Count);
            for (int i = 0; i < addExtra; i++)
            {
                int randomGum = random.Next(0, extraGums.Count);
                gums.Add(extraGums[randomGum]);
                extraGums.RemoveAt(randomGum);
            }
        }




       /// <summary>
       /// Method to remove a gum from the list of gums
       /// </summary>
       /// <returns></returns>
       public ChewingGum RemoveGum()
        {
            if (gums.Count == 0)
            {
                return null;
            }
            int randomRemove = random.Next(0, gums.Count);
            luckyGum = gums[randomRemove];
            gums.RemoveAt(randomRemove);
            return luckyGum;
        }




       /// <summary>
       /// Method to choose between 1 or 2
       /// </summary>
       /// <returns></returns>
       public bool Choose()
        {
            while (true)
            {

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        return true;
                    case '2':
                        return false;
                }
            }
        }
    }
}
