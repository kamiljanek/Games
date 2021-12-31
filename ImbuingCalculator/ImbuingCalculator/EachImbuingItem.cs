using System;
using System.Collections.Generic;
using System.Text;

namespace ImbuingCalculator
{
    public class EachImbuingItem
    {

        /// <summary>
        /// Create item which you need to Imbuing
        /// </summary>
        /// <param name="quantityNeeded">How meny items do you need to imbuing?</param>
        /// <param name="firstName">First name of item</param>
        /// <param name="secondName">Second name of item (if needed)</param>
        /// <param name="thirdName">Third name of item (if needed)</param>
        /// <param name="fourthName">Fourth name of item (if needed)</param>
        public EachImbuingItem(int quantityNeeded, string firstName, string secondName = null, string thirdName = null, string fourthName = null)
        {
            QuantityNeeded = quantityNeeded;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            FourthName = fourthName;

        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FourthName { get; set; }
        public int QuantityNeeded { get; set; }
        public int Price { get; set; }

        /// <summary>
        /// Read each item price from user
        /// </summary>
        /// <param name="eachImbuingItem">The specific item</param>
        public int EachImbuingItemPrice(EachImbuingItem eachImbuingItem)
        {
            Console.WriteLine($"{eachImbuingItem.FirstName} {eachImbuingItem.SecondName} {eachImbuingItem.ThirdName} {eachImbuingItem.FourthName} price {GoldUnit.unit}:");
            string input = Console.ReadLine();

            int eachImbuingItemPrice = Convert.ToInt32(input);
            return eachImbuingItemPrice;
        }

    }
}
