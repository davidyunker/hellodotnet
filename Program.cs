using System;

namespace TackleWareHouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime purchaseDate = Convert.ToDateTime(args[1]);
            int numberPurchased = Convert.ToInt16(args[2]);
            int purchasePrice = Convert.ToInt16(args[3]);
            Customer customer = new Customer();
            customer.firstName = args[0];
            string greeting = customer.CustomerGreeting(purchaseDate, numberPurchased, purchasePrice);

            string discountMessage = customer.ApplyDiscount();


            Console.WriteLine(greeting + discountMessage);
        }

    }
}
