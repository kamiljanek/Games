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
        public ImbuingType(string name, List<ImbuingItem> imbuingItemsList)
        {
            Name = name;
            ImbuingItemList = imbuingItemsList;

        }

        public string Name { get; set; }
        public List<ImbuingItem> ImbuingItemList { get; set; }
        public ImbuingItem ImbuingItem { get; set; }

     
        /// <summary>
        /// Calculate whole specific Imbuing price
        /// </summary>
        /// <param name="ImbuingItemList">The list of specific Imbuing items</param>
        /// <returns></returns>
        public static int IndividualImbuingPrice(List<ImbuingItem> ImbuingItemList)
        {
            int individualImbuingPrice = 0;
            foreach (var item in ImbuingItemList)
            {
                int a = item.QuantityNeeded * item.Price;   //"a" assistance variable
                individualImbuingPrice += a;
            }

            return individualImbuingPrice;
        }
        /// <summary>
        /// Return Intricate Imbuing price
        /// </summary>
        /// <param name="ImbuingItemList">Choosen Imbuing items list</param>
        /// <returns></returns>
        public static int IndividualImbuingIntricatePrice(List<ImbuingItem> ImbuingItemList)
        {
            int IndividualImbuingIntricatePrice = 0;
            for (int i = 0; i < 2; i++)
            {
                int a = ImbuingItemList[i].QuantityNeeded * ImbuingItemList[i].Price;    //"a" assistance variable
                IndividualImbuingIntricatePrice += a;
            }
            return IndividualImbuingIntricatePrice;
        }
        /// <summary>
        /// Gold Tokens price subtract Imbuing price
        /// </summary>
        /// <param name="chosenImbuingPrice">int Price</param>
        /// <param name="goldTokensPrice">int Price</param>
        /// <returns></returns>
        public static int Calculation(int chosenImbuingPrice, int goldTokensPrice)
        {
            int result = goldTokensPrice - chosenImbuingPrice;
            return result;
        }
    }
}
