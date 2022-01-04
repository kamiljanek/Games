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
                var entityGoldTokenPrice = ImbuingType.EntityImbuingPrice(imbuingTypes[3].ImbuingItemsList);

                result = ImbuingType.Calculation(entityImbuingPrice, entityGoldTokenPrice);
            }
            else
            {
                goto startLocalMenu;
            }

            if (chooseLocalMenuInt == 4)
            {
                goto startMainMenu;
            }
            else if (result == 0)
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
            Console.ForegroundColor = ConsoleColor.White;
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

        public static EachImbuingItem protectiveCharm = new EachImbuingItem(20, "Protective Charm");                                 // dlaczego tu musze miec "static"?
        public static EachImbuingItem sabretooth = new EachImbuingItem(25, "Sabretooth");
        public static EachImbuingItem vexclawTalon = new EachImbuingItem(5, "Vexclaw Talon");
        public static EachImbuingItem ropeBelt = new EachImbuingItem(25, "RopeBelt");
        public static EachImbuingItem silencerClaws = new EachImbuingItem(25, "Silencer Claws");
        public static EachImbuingItem grimeleechWings = new EachImbuingItem(5, "Grimeleech Wings");
        public static EachImbuingItem vampireTeeth = new EachImbuingItem(25, "Vampire Teeth");
        public static EachImbuingItem bloodyPincers = new EachImbuingItem(15, "Bloody Pincers");
        public static EachImbuingItem pieceOfDeadBrain = new EachImbuingItem(5, "Piece Of Dead Brain");
        public static EachImbuingItem goldToken = new EachImbuingItem(6, "Gold Token");


        public static List<EachImbuingItem> criticalItemsList = new List<EachImbuingItem>
        {
        protectiveCharm,
        sabretooth,
        vexclawTalon
        };

        public static List<EachImbuingItem> manaLeechItemsList = new List<EachImbuingItem>
        {
        ropeBelt,
        silencerClaws,
        grimeleechWings
        };
        public static List<EachImbuingItem> lifeLeechItemsList = new List<EachImbuingItem>
        {
        vampireTeeth,
        bloodyPincers,
        pieceOfDeadBrain
        };

        public static List<EachImbuingItem> goldTokensList = new List<EachImbuingItem>
        {
        goldToken
        };

        public static ImbuingType criticalImbuingType = new ImbuingType("Critical", criticalItemsList);
        public static ImbuingType manaLeechImbuingType = new ImbuingType("Mana Leech", manaLeechItemsList);
        public static ImbuingType lifeLeechImbuingType = new ImbuingType("Life Leech", lifeLeechItemsList);
        public static ImbuingType goldTokenType = new ImbuingType("Gold Token", goldTokensList);

        public static List<ImbuingType> imbuingTypes = new List<ImbuingType>
        {
            criticalImbuingType,
            manaLeechImbuingType,
            lifeLeechImbuingType,
            goldTokenType
        };


    }

}
