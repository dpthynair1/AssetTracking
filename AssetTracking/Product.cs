using System;
namespace AssetTracking
{
    public  abstract class Product
    {
        public Product()
        {


        }


        public string Category { get; set; }
        public string ProdName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double Price { get; set; }
        public string ModelName { get; set; }

        public abstract string Log();
        public abstract void LogByExpiry(int daysLeft);



    }
}

