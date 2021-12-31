using System;
using System.Collections.Generic;
using System.Text;

namespace ImbuingCalculator
{
    public class ImbuingType
    {
        public ImbuingType(string name, List<EachImbuingItem> imbuingItemsList)
        {
            Name = name;
            ImbuingItemsList = imbuingItemsList;

        }
        public ImbuingType(string name, EachImbuingItem imbuingItem)
        {
            Name = name;
            ImbuingItem = imbuingItem;

        }
        public string Name { get; set; }
        public List<EachImbuingItem> ImbuingItemsList { get; set; }
        public EachImbuingItem ImbuingItem { get; set; }

        /// <summary>
        /// Create menu to specific Imbuing
        /// </summary>
        /// <param name="eachImbuingItemsList">The list of specific Imbuing items</param>
        public void EntityImbuingMenu(List<EachImbuingItem> eachImbuingItemList)
        {
            Console.Clear();
            Console.WriteLine();
            int i = 1;
            foreach (var item in eachImbuingItemList)
            {
                Console.WriteLine($"{i}. {item.FirstName} {item.SecondName} {item.ThirdName} {item.FourthName} Price");
                i++;
            }
            Console.WriteLine($"{i}. Calculate...");
            Console.WriteLine();
            Console.Write("Choose item: ");
        }
        /// <summary>
        /// Calculate whole specific Imbuing price
        /// </summary>
        /// <param name="eachImbuingItemList">The list of specific Imbuing items</param>
        /// <returns></returns>
        public int EntityImpuingPrice(List<EachImbuingItem> eachImbuingItemList)
        {
            int entityImpuingPrice = 0;
            foreach (var item in eachImbuingItemList)
            {
                int a = item.QuantityNeeded * item.Price;   //"a" assistance variable
                entityImpuingPrice += a;
            }

            return entityImpuingPrice;
        }
        public int Calculation(int specificImpuingPrice, int goldTokenPrice)
        {
            int result = 6 * goldTokenPrice - specificImpuingPrice;
            return result;
        }
    }
}
