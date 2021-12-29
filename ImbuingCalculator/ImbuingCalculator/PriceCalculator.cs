using System;
using System.Collections.Generic;
using System.Text;

namespace ImbuingCalculator
{
    public class PriceCalculator
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
}
