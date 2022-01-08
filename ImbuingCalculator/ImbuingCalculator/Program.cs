using System;
using System.Collections.Generic;

namespace ImbuingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        #region All Program

        startMainMenu:

            MainMenu(ImbuingTypes);

            while ((ChooseMenuInt <= 0) | (ChooseMenuInt >= 5))
            {
                MainMenu(ImbuingTypes);
            }

            var chooseLocalMenuInt = ChooseMenuInt;

        startLocalMenu:

            MainMenu(ImbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList);
            if (ChooseMenuInt > 0 & ChooseMenuInt < 4)
            {
                ImbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList[ChooseMenuInt - 1].Price = EachImbuingItem.EachImbuingItemPrice(ImbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList[ChooseMenuInt - 1]);
            }
            else if (ChooseMenuInt == 4)
            {
                EntityImbuingPrice = ImbuingType.EntityImbuingPrice(ImbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList);
                var entityGoldTokenPrice = ImbuingType.EntityImbuingPrice(ImbuingTypes[0].ImbuingItemsList);

                Result = ImbuingType.Calculation(EntityImbuingPrice, entityGoldTokenPrice);
            }
            else
            {
                goto startLocalMenu;
            }

            if (chooseLocalMenuInt == 1)
            {
                goto startMainMenu;
            }
            else if (ChooseMenuInt > 0 & ChooseMenuInt < 4)
            {
                goto startLocalMenu;
            }

            if (Result > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"If you will buy 6 Gold Tokens instead of items you will LOOSE {Result} {GoldUnit.Unit}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"If you will buy 6 Gold Tokens instead of items you will SAVE {Math.Abs(Result)} {GoldUnit.Unit}");
            }

            if (Result > -40000)
            {
                var entityImbuingLastItemPrice = ImbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList[2].QuantityNeeded * ImbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList[2].Price;
                var entityGoldTokenIntricatePrice = 4 * GoldTokensList[0].Price;

                Result = EntityImbuingPrice - (entityGoldTokenIntricatePrice + entityImbuingLastItemPrice);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"But if you will buy 4 Gold Tokens and last items you SAVE {Result} {GoldUnit.Unit} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("PUSH BUTTON TO CONTINUE...");
            Console.ReadKey();


            goto startMainMenu;
        #endregion
        }

        #region Menu methods

        /// <summary>
        /// Print Main Menu from Imbuing List
        /// </summary>
        /// <param name="imbuingTypeList"></param>
        static void MainMenu(List<ImbuingType> imbuingTypeList)
        {
            Console.Clear();
            Centering.CenteringWriteLine(title);
            Console.WriteLine();
            int i = 1;
            foreach (var item in imbuingTypeList)
            {
                Console.WriteLine($"{i}. {item.Name}");
                i++;
            }
            Console.WriteLine();
            Console.Write("Choose item: ");
            ChooseMenu = Console.ReadLine();
            ChooseMenuInt = Int32.Parse(ChooseMenu);
        }
        /// <summary>
        /// Print choosen Imbuing Menu from specific Imbuing items List
        /// </summary>
        /// <param name="imbuingTypeList"></param>
        static void MainMenu(List<EachImbuingItem> imbuingTypeList)         //how to conect 2 MainMenu methods???
        {
            Console.Clear();
            Centering.CenteringWriteLine(title);
            Console.WriteLine();
            int i = 1;
            foreach (var item in imbuingTypeList)
            {
                Console.WriteLine($"{i}. {item.Name}");
                i++;
            }
            Console.WriteLine($"{i}. Calculate");
            Console.WriteLine();
            Console.Write("Choose item: ");
            ChooseMenu = Console.ReadLine();
            ChooseMenuInt = Int32.Parse(ChooseMenu);
        }
        #endregion

        #region constant values

        const string title = "IMBUING CALCULATOR";

        public static string ChooseMenu;
        public static int ChooseMenuInt;
        public static int Result;
        public static int EntityImbuingPrice;
        #endregion

        #region Create instances and Imbuing Lists

        public static List<EachImbuingItem> CriticalItemsList = new List<EachImbuingItem>
        {
        new EachImbuingItem(20, "Protective Charm"),
        new EachImbuingItem(25, "Sabretooth"),
        new EachImbuingItem(5, "Vexclaw Talon")
        };

        public static List<EachImbuingItem> ManaLeechItemsList = new List<EachImbuingItem>
        {
        new EachImbuingItem(25, "RopeBelt"),
        new EachImbuingItem(25, "Silencer Claws"),
        new EachImbuingItem(5, "Grimeleech Wings")
        };
        public static List<EachImbuingItem> LifeLeechItemsList = new List<EachImbuingItem>
        {
        new EachImbuingItem(25, "Vampire Teeth"),
        new EachImbuingItem(15, "Bloody Pincers"),
        new EachImbuingItem(5, "Piece Of Dead Brain")
        };

        public static List<EachImbuingItem> GoldTokensList = new List<EachImbuingItem>
        {
        new EachImbuingItem(6, "Gold Token")
        };


        public static List<ImbuingType> ImbuingTypes = new List<ImbuingType>
        {
            new ImbuingType("Gold Token", GoldTokensList),
            new ImbuingType("Critical", CriticalItemsList),
            new ImbuingType("Mana Leech", ManaLeechItemsList),
            new ImbuingType("Life Leech", LifeLeechItemsList)
        };
        #endregion

    }

}
