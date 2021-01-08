using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assets
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Asset> assets = new List<Asset>();

          //DateTime dateTime = new DateTime();

            string Input;
    //      Category = use.Entry();

            while (Input != "exit")
                
            {

                if ((Input == "laptop" || Input == "phone"))
                {
                    string AssetName = null;
                    string assetname = AssetName;
                    string Model = null;
                    string model = Model;
                    DateTime purdate = default;
                    double Price = 0;
                    //DateTime = purdate;
                    double price = Price;

                    if (Input == "laptop")
                    {
                        Laptop laptop = new Laptop();
                        assets.Add(laptop);
                    }
                    else
                    {


                        Phone phone = new Phone();

                        assets.Add(phone);
                    }


                }


            }


            /*Console.WriteLine("Enter Add to add a Laptop to your List . Press quit to exit");
              input = Console.ReadLine();
              input = input.ToLower();

              // laptop model
              Console.Write("Enter the Laptop model name: ");
              string model = Console.ReadLine();
              model = model.ToLower();

              // laptop price
              Console.Write("Enter the Laptop price: ");
              string amount = Console.ReadLine();

              double price = double.Parse(amount);

              // datetime
              Console.Write("Enter the purchase date: ");

              DateTime Purdate = new DateTime();
              Purdate = Convert.ToDateTime("2021-01-05");


              Console.ReadLine(); */


        }
  

        
        // laptops
  /* laptop.AddRange(new List<Laptop>

        {
            new Laptop("MacBook", 10050, new DateTime(2012, 01, 05), "red"),
new Laptop("Asus", 6500, new DateTime(2019, 06, 25), "white"),
            new Laptop("Lenovo", 4500, new DateTime(2017, 04, 11), "silver")
        });

          // method

          foreach (Laptop item in laptop)
          {
            Console.WriteLine("Laptop: {0},{1},{2}", item.Model, item.Price, item.Purdate, item.LaptopCol);

          } 

            // Console.WriteLine(laptops); 
        } */
    }
}
