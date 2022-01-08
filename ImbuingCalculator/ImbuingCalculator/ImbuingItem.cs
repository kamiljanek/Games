using System;
using System.Collections.Generic;
using System.Text;

namespace ImbuingCalculator
{
    public class ImbuingItem
    {

        /// <summary>
        /// Create item which you need to Imbuing
        /// </summary>
        /// <param name="quantityNeeded">How meny items do you need to imbuing?</param>
        /// <param name="name">First name of item</param>
        public ImbuingItem(int quantityNeeded, string name)
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
        /// <param name="ImbuingItem">The specific item</param>
        public static int SingleImbuingItemPrice(ImbuingItem ImbuingItem)
        {
            Console.Write($"{ImbuingItem.Name} price {ConstantValues.Unit}:");
            string input = Console.ReadLine();

            int singleImbuingItemPrice = Convert.ToInt32(input);
            return singleImbuingItemPrice;
        }

    }
}
