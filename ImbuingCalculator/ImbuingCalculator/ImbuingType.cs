using System;
using System.Collections.Generic;
using System.Text;

namespace ImbuingCalculator
{
    public class ImbuingType
    {/// <summary>
    /// Create Imbuing Entity
    /// </summary>
    /// <param name="name">Name of Imbuing</param>
    /// <param name="imbuingItemsList">Lisf of items contains this Imbuing</param>
        public ImbuingType(string name, List<EachImbuingItem> imbuingItemsList)
        {
            Name = name;
            ImbuingItemsList = imbuingItemsList;

        }

        public string Name { get; set; }
        public List<EachImbuingItem> ImbuingItemsList { get; set; }
        public EachImbuingItem ImbuingItem { get; set; }

     
        /// <summary>
        /// Calculate whole specific Imbuing price
        /// </summary>
        /// <param name="eachImbuingItemList">The list of specific Imbuing items</param>
        /// <returns></returns>
        public static int EntityImbuingPrice(List<EachImbuingItem> eachImbuingItemList)
        {
            int entityImpuingPrice = 0;
            foreach (var item in eachImbuingItemList)
            {
                int a = item.QuantityNeeded * item.Price;   //"a" assistance variable
                entityImpuingPrice += a;
            }

            return entityImpuingPrice;
        }
        public static int EntityImbuingIntricatePrice(List<EachImbuingItem> eachImbuingItemList)
        {
            int entityImpuingIntricatePrice = 0;
            for (int i = 0; i < 2; i++)
            {
                int a = eachImbuingItemList[i].QuantityNeeded * eachImbuingItemList[i].Price;    //"a" assistance variable
                entityImpuingIntricatePrice += a;
            }
            return entityImpuingIntricatePrice;
        }
        public static int Calculation(int specificImbuingPrice, int goldTokenPrice)
        {
            int result = goldTokenPrice - specificImbuingPrice;
            return result;
        }
    }
}
