using System;
using System.Collections.Generic;
using System.Text;

namespace ImbuingCalculator
{
    public static class Centering
    {
        /// <summary>
        /// Centering "WriteLine" 
        /// </summary>
        /// <param name="writeLine"></param>
        public static void CenteringWriteLine(string writeLine)
        {
            Console.SetCursorPosition((Console.WindowWidth - writeLine.Length) / 2, Console.CursorTop);
            Console.WriteLine(writeLine);
        }
    }
   

}
