using System;
using System.Collections.Generic;
using System.Text;

namespace Assets
{
   public abstract class Asset

    {     
        public string Model { get; set; }
        public double Price { get; set; }
        public DateTime Purdate { get; set; }      

        public string Category { get; set; }

        public string AssetName { get; set; }

        public abstract string Panel();
        public abstract void ExpiryDate(int timeSpan);

    }  
}
