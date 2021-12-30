using System;
using System.Collections.Generic;
using System.Text;

namespace ImbuingCalculator
{
    public class Price
    {
        public void CenteringWriteLine(string writeLine)
        {
            Console.SetCursorPosition((Console.WindowWidth - writeLine.Length) / 2, Console.CursorTop); //centering text
            Console.WriteLine(writeLine);
        }
        public void Menu()
        {

        }
    }
    public class ImbuingType
    {
        public ImbuingType(string name, List<EachImbuingItem> imbuingItemsList)
        {
            Name = name;
            ImbuingItemsList = imbuingItemsList;
          
        }
        public string Name { get; set; }
        public List<EachImbuingItem> ImbuingItemsList { get; set; }


        public void Menu()
        {
                Console.Clear();
                Console.WriteLine();
            int i = 1;
            foreach (var item in ImbuingItemsList)
            {
                i = 1;
                Console.WriteLine($"{i}. {item.FirstName} {item.SecondName} {item.ThirdName} {item.FourthName} Price");
                i++;
            }
            Console.WriteLine($"{i}. Calculate...");
            Console.WriteLine();
            Console.Write("Choose item: ");
        }
        public int Calculation(int itemsPrice, int goldTokenPrice)
        {
            int result = 6 * goldTokenPrice - itemsPrice;
            return result;
        }
    }

}
