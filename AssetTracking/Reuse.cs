using System;
namespace AssetTracking
{
    public class Reuse
    {
        public Reuse()
        {
        }
        

        public string ProductModel()
        {
            Console.WriteLine("Enter Model");
            string model = Console.ReadLine();
            return model;
        }

        public double Price()
        {
            double prodPrice;
            double userPrice;
            Boolean validPrice;
             do
            {
                 Console.WriteLine("Enter Price");

                if(Double.TryParse(Console.ReadLine(), out userPrice))
                {
                      validPrice = true;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value.");
                    validPrice = false;
                }
               
            } while (!validPrice);

            prodPrice = userPrice;
          

            return prodPrice;
        }

       public DateTime PurchaseDate()
        {
            DateTime userDateTime;
            DateTime date;
            Boolean validDate;
            do
            {
                Console.WriteLine("Enter a date: ");

                if (DateTime.TryParse(Console.   ReadLine(), out userDateTime))

                {
                     validDate = true;
                }

                else

                {
                    Console.WriteLine("You have entered an incorrect value.");
                    validDate = false;
                }
               
            } while (!validDate);


            date = userDateTime;
            return date;
        }


        public string ProductName()
        {
            Console.WriteLine("Enter Product Name");
            string prodName = Console.ReadLine();
            return prodName;
        }

        public string Entry()
        {
            string Category;
            Console.WriteLine("Select a Category: Computer / Mobile");
            Category = Console.ReadLine();
            Category = Category.ToLower();

            return Category;
        }


        public void InvalidEntry()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Category");
            Console.ResetColor();

        }

        public int ExpiryDateCalculation(DateTime dateOnly)
        {
            DateTime expiry = dateOnly.AddYears(3);
            DateTime date2 = DateTime.Today;
            TimeSpan timeSpan = expiry - date2;
            double days = timeSpan.TotalDays;
            int daysLeft = Convert.ToInt32(days);
           
            return daysLeft;
        }
       
      

    }
}
