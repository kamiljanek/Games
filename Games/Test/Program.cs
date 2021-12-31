using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] lista = { 112, 24, 3 };
            SpecificImpuingPrice(lista);



            static void SpecificImpuingPrice(int[] eachImbuingItemList)
            {
                int result = 0;
                foreach (var item in eachImbuingItemList)
                {
                    int cos = item;
                    result += cos;

                }
                Console.WriteLine(result);
            }
        }
    }
}
