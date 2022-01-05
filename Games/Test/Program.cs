using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EachImbuingItem jedenn = new EachImbuingItem(1, "jeden");
            EachImbuingItem dwaa = new EachImbuingItem(2, "dwa");
            EachImbuingItem trzyy = new EachImbuingItem(3, "trzy");

            List<EachImbuingItem> listaa = new List<EachImbuingItem>
            {
                new EachImbuingItem(1,"jeden"),
                new EachImbuingItem(2,"dwa"),
                new EachImbuingItem(3,"trzy")
            };
            var pierwszyElementListy = listaa[0];
            Console.WriteLine(pierwszyElementListy[1]);
        }
    }
}
