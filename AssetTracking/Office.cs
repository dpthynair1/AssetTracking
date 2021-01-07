using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetTracking
{
    public class Office
    {
        public Office(string location)
        {
            new List<Product>();
            Location = location;
        }

        public Office()
        {
        }

        string Location { get; set; }

        
        Reuse use = new Reuse();
       
        DateTime dateTime = new DateTime();
       

        List<Product> InventoryList { get; set; }

        Office office = new Office();

        public void addProduct(Product  product)
        {
            InventoryList.Add(product);
        }

        public List<Product> CreateProduct()
        {
            string Category;

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
                        this.InventoryList.Add(mobile);
                    }
                    else
                    {


                        Computer computer = new Computer(Category, prodName, model, dateTime, prodPrice);
                       // InventoryList.Add(computer);

                        office.InventoryList.Add(computer);
                    }


                }

                else
                {
                    use.InvalidEntry();
                }

                Category = use.Entry();
            }

            return InventoryList;
        }


        public void SortProductsByCLass()
        {
            Console.WriteLine("****** Sorted by Class *****");
            var ordered = InventoryList.OrderBy(x => x.Category).ToList();
            foreach (var item in ordered)
            {
                int daysLeft = use.ExpiryDateCalculation(item.PurchaseDate);

                item.LogByExpiry(daysLeft);
            }
           
        }


        public void SortByPurchseDate()
        {
            Console.WriteLine("****** Sorted by Purchase Date *****");
            var SortedByDate = InventoryList.OrderBy(x => x.PurchaseDate).ToList();

            foreach (var item in SortedByDate)
            {
                int daysLeft = use.ExpiryDateCalculation(item.PurchaseDate);
                item.LogByExpiry(daysLeft);

            }
        }


    }
}
