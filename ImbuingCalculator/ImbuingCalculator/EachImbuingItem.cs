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
        /// <param name="quantityNeeded">How many this items you need to imbuing?</param>
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
        public string Price { get; set; }

        public void WriteEachItemTitle()
        {
            Console.WriteLine($"{0} {1} {2} {3} price {GoldUnit.unit}:");
        }
        public int EachImbuingItemPrice()
        {
            string input = Console.ReadLine();

            int eachImbuingItemPrice = Convert.ToInt32(input);
            return eachImbuingItemPrice;
        }
    }
}
