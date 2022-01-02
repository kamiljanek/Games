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
        /// <param name="name">First name of item</param>
        public EachImbuingItem(int quantityNeeded, string name)
        {
            QuantityNeeded = quantityNeeded;
            Name = name;

        }
        public string Name { get; set; }
        public int QuantityNeeded { get; set; }
        public int Price { get; set; }

        /// <summary>
        /// Read each item price from user
        /// </summary>
        /// <param name="eachImbuingItem">The specific item</param>
        public static int EachImbuingItemPrice(EachImbuingItem eachImbuingItem)
        {
            Console.Write($"{eachImbuingItem.Name} price {GoldUnit.unit}:");
            string input = Console.ReadLine();

            int eachImbuingItemPrice = Convert.ToInt32(input);
            return eachImbuingItemPrice;
        }

    }
}
