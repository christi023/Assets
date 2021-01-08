using System;
using System.Collections.Generic;
using System.Text;

namespace Assets
{
    class Phone : Asset // inheritance
    {
        public Phone()
        { }

        public Phone(string model, double price, DateTime purdate, string category, string assetname)
        {
            Model = model;
            Price = price;
            Purdate = purdate;
            Category = category;
            AssetName = assetname;
        }

        // heading - cols
        public override string Panel() => $"{Category.PadRight(15)}{AssetName.PadRight(8)}{Model.PadRight(8)}{Purdate.ToShortDateString().PadRight(8)}\t{Price}";


        // time span
        public override void ExpiryDate(int timeSpan)
        {

            if (timeSpan <= 90 && timeSpan > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Panel());
                Console.ResetColor();
            }
            else if (timeSpan <= 180 && timeSpan > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Panel());
                Console.ResetColor();
            }
            else if (timeSpan < 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Panel());
                Console.ResetColor();
            }


        }

    }
}
