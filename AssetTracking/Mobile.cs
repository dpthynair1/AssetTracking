using System;
namespace AssetTracking
{
    public class Mobile : Product
    {
        public Mobile()
        {
        }

        public Mobile(string category, string prodName, string modelName, DateTime purchaseDate, double price)
        {
            Category = category;
            ProdName = prodName;
            PurchaseDate = purchaseDate;
            Price = price;
            ModelName = modelName;

         
        }



        public override string Log() => $"{Category.PadRight(15)}{ProdName.PadRight(8)}{ModelName.PadRight(8)}{PurchaseDate.ToShortDateString().PadRight(8)}{Price}";


        public override void LogByExpiry(int daysLeft)
        {

            if (daysLeft <= 90 && daysLeft > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(this.Log());
                Console.ResetColor();
            }
            else if (daysLeft <= 180 && daysLeft > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(this.Log());
                Console.ResetColor();
            }
            else if (daysLeft < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(this.Log());
                Console.ResetColor();
            }
        }



    }
}
