using System;
using System.Collections.Generic;
using System.Text;

namespace chewingGumDispenser
{
    class ChewingGum
    {

        #region Fields
        private string taste;
        private string color;
        #endregion




        #region Properties

        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        #endregion




        #region Constructors
        public ChewingGum()
        {

        }
        public ChewingGum(string taste, string color)
        {
            this.taste = taste;
            this.color = color;
        }
        #endregion
    }
}
