using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Methods
    {
        public string Calculate(int yearOfBirth)
        {
            int age = DateTime.Now.Year - yearOfBirth;
            if (age < 18)
            {
                return "you are minor";
            }
            else
            {
                return "you are full of age";
            }
        }
        public string UpperCase(string stri)
        {
            return stri.ToUpper();
        }
        public string LowerCase(string stri)
        {
            return stri.ToLower();
        }
        public void Display(string s1, string s2)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(s1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(s2);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void Display2(string s1, string s2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(s1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" : ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(s2);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
