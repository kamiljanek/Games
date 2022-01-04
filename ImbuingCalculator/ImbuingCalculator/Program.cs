using System;
using System.Collections.Generic;

namespace ImbuingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        startMainMenu:

            MainMenu(imbuingTypes);

            while ((chooseMenuInt <= 0) | (chooseMenuInt >= 5))
            {
                MainMenu(imbuingTypes);
            }

            var chooseLocalMenuInt = chooseMenuInt;

        startLocalMenu:

            MainMenu(imbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList);
            if (chooseMenuInt > 0 & chooseMenuInt < 4)
            {
                imbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList[chooseMenuInt - 1].Price = EachImbuingItem.EachImbuingItemPrice(imbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList[chooseMenuInt - 1]);
            }
            else if (chooseMenuInt == 4)
            {
                var entityImbuingPrice = ImbuingType.EntityImbuingPrice(imbuingTypes[chooseLocalMenuInt - 1].ImbuingItemsList);
                var entityGoldTokenPrice = ImbuingType.EntityImbuingPrice(imbuingTypes[0].ImbuingItemsList);

                result = ImbuingType.Calculation(entityImbuingPrice, entityGoldTokenPrice);
            }
            else
            {
                goto startLocalMenu;
            }

            if (chooseLocalMenuInt == 1)
            {
                goto startMainMenu;
            }
            else if (chooseMenuInt > 0 & chooseMenuInt < 4)
            {
                goto startLocalMenu;
            }

            if (result > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"If you will buy Gold Tokens instead of items you will LOOSE {result} {GoldUnit.unit}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"If you will buy Gold Tokens instead of items you will EARN {Math.Abs(result)} {GoldUnit.unit}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("PUSH BUTTON TO CONTINUE...");
            Console.ReadKey();
            goto startMainMenu;

        }
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
            chooseMenu = Console.ReadLine();
            chooseMenuInt = Int32.Parse(chooseMenu);
        }
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
            chooseMenu = Console.ReadLine();
            chooseMenuInt = Int32.Parse(chooseMenu);
        }


        const string title = "IMBUING CALCULATOR";

        public static string chooseMenu;
        public static int chooseMenuInt;
        public static int result;

        public static List<EachImbuingItem> criticalItemsList = new List<EachImbuingItem>
        {
        new EachImbuingItem(20, "Protective Charm"),
        new EachImbuingItem(25, "Sabretooth"),
        new EachImbuingItem(5, "Vexclaw Talon")
        };

        public static List<EachImbuingItem> manaLeechItemsList = new List<EachImbuingItem>
        {
        new EachImbuingItem(25, "RopeBelt"),
        new EachImbuingItem(25, "Silencer Claws"),
        new EachImbuingItem(5, "Grimeleech Wings")
        };
        public static List<EachImbuingItem> lifeLeechItemsList = new List<EachImbuingItem>
        {
        new EachImbuingItem(25, "Vampire Teeth"),
        new EachImbuingItem(15, "Bloody Pincers"),
        new EachImbuingItem(5, "Piece Of Dead Brain")
        };

        public static List<EachImbuingItem> goldTokensList = new List<EachImbuingItem>
        {
        new EachImbuingItem(6, "Gold Token")
        };

        public static ImbuingType criticalImbuingType = new ImbuingType("Critical", criticalItemsList);
        public static ImbuingType manaLeechImbuingType = new ImbuingType("Mana Leech", manaLeechItemsList);
        public static ImbuingType lifeLeechImbuingType = new ImbuingType("Life Leech", lifeLeechItemsList);
        public static ImbuingType goldTokenType = new ImbuingType("Gold Token", goldTokensList);

        public static List<ImbuingType> imbuingTypes = new List<ImbuingType>
        {
            new ImbuingType("Gold Token", goldTokensList),
            new ImbuingType("Critical", criticalItemsList),
            new ImbuingType("Mana Leech", manaLeechItemsList),
            new ImbuingType("Life Leech", lifeLeechItemsList)
        };


    }

}
