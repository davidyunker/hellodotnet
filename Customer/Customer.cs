using System;
using System.Text;

namespace TackleWareHouse 
{
    public class Customer
    {
        public string firstName{get;set;}
        // this is a property on the customer 
            public string CustomerGreeting(DateTime purchaseDate, int numberPurchased, int purchasePrice)
        {
            string greeting=String.Empty;
            var finalPrice = numberPurchased * purchasePrice;

            StringBuilder sb =new StringBuilder();
            sb.Append("Hello ");
            sb.Append(this.firstName + "!" + " You purchased a vinyl record on ");
            sb.Append(purchaseDate.ToString());
            sb.Append(" Final Price =" + finalPrice);
            greeting=sb.ToString();


            return greeting;
        }
        public string ApplyDiscount()
        {
            string success=string.Empty; 
            if(this.firstName=="billy")
            {
                // TODO Apply the discount by hitting the blah blah api 
                success="Discount Applied";

            }
            else 
            {
                success="Sorry no discount for you";

            }
            return success; 
        }     
    }
}