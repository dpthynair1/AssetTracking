using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace AssetTracking
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> InventoryList = new List<Product>();

            Reuse use = new Reuse();
           
            DateTime dateTime = new DateTime();
            string Category ;

            
           


            Category = use.Entry();


            while (Category != "exit") 
            {
          

                if ((Category == "computer") || (Category == "mobile"))
                {
                    string prodName = use.ProductName();
                    string model = use.ProductModel();
                    dateTime = use.PurchaseDate();
                    double prodPrice = use.Price();
                    if (Category == "mobile")
                    {
                        Mobile mobile = new Mobile(Category, prodName, model, dateTime, prodPrice);
                        InventoryList.Add(mobile);
                    }
                    else {


                        Computer computer = new Computer(Category, prodName, model, dateTime, prodPrice);
                        InventoryList.Add(computer);
                    }
                 

                }
               
                else
                {
                    use.InvalidEntry();
                }

               Category =  use.Entry();
            }








            foreach (var item in InventoryList)
            {
                Console.WriteLine(item.Log().ToString());
            }


            // Sort
            Console.WriteLine("****** Sorted by Class *****");
            Console.WriteLine("");
            var ordered = InventoryList.OrderBy(x => x.Category).ToList();
            foreach (var item in ordered)
            {
                int daysLeft = use.ExpiryDateCalculation(item.PurchaseDate);

                item.LogByExpiry(daysLeft);
            }
            Console.WriteLine("");

            Console.WriteLine("****** Sorted by Purchase Date *****");
            Console.WriteLine("");
            var SortedByDate = InventoryList.OrderBy(x => x.PurchaseDate).ToList();

            foreach(var item in SortedByDate)
            {
               int daysLeft = use.ExpiryDateCalculation(item.PurchaseDate);

                item.LogByExpiry(daysLeft);
            }

            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}
