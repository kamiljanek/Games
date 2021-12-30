﻿using System;

namespace ImbuingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        const string title = "IMBUING CALCULATOR";
        public const string unit = "[Gold Coin]";

        static int protectiveCharmPrice;
        static int sabretoothPrice;
        static int vexclawTalonPrice;
        
        static int vampireTeethPrice;
        static int bloodyPincersPrice;
        static int pieceOfDeadBrainPrice;

        static int ropeBeltPrice;
        static int silencerClawsPrice;
        static int grimeleechWingsPrice;

        static int criticalImbuingPrice;
        static int lifeLeechImbuingPrice;
        static int manaLeechImbuingPrice;
        
        static int goldTokenPrice;

        static int calculation;
        static string earnOrLoose = "";



        static void MainMenu()
        {
            CenteringWriteLine(title);
            Menu();

            string chooseMenu = Console.ReadLine();
            switch (chooseMenu)
            {
                case "1":
                    goldTokenPrice = GoldTokenPrice();
                    Console.Clear();
                    MainMenu();
                    break;

                case "2":
                    CriticalImbuing();
                    break;

                case "3":
                    LifeLeechImbuing();
                    break;

                case "4":
                    ManaLeechImbuing();
                    break;

                default:
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }

        private static void Menu()
        {
            Console.WriteLine("1. Gold Token Price");
            Console.WriteLine("2. Critical Imbuing");
            Console.WriteLine("3. Life Leech Imbuing");
            Console.WriteLine("4. Mana Leech Imbuing");
            Console.WriteLine();
            Console.Write("Choose Imbuing: ");
        }

        static int GoldTokenPrice()
        {
            Console.Clear();
            CenteringWriteLine(title);
            Console.WriteLine();
            Console.Write($"Gold Token Price {unit}: ");
            string input = Console.ReadLine();
            int goldTokenPrice = Convert.ToInt32(input);
            return goldTokenPrice;
        }
        #region Critical Imbuing


        static void CriticalImbuing()
        {
            Console.Clear();
            CenteringWriteLine(title);
            Console.WriteLine();
            Console.WriteLine("1. Protective Charm Price");
            Console.WriteLine("2. Sabretooth Price");
            Console.WriteLine("3. Vexclav Talon Price");
            Console.WriteLine("4. Calculate...");
            Console.WriteLine();
            Console.Write("Choose item: ");
            var criticalElementPrice = Console.ReadLine();

            switch (criticalElementPrice)
            {
                case "1":
                    protectiveCharmPrice = ProtectiveCharmPrice();
                    CriticalImbuing();
                    break;

                case "2":
                    sabretoothPrice = SabretoothPrice();
                    CriticalImbuing();
                    break;

                case "3":
                    vexclawTalonPrice = VexclawTalonPrice();
                    CriticalImbuing();
                    break;

                case "4":
                    criticalImbuingPrice = CriticalImbuingPrice();
                    calculation = Calculation(criticalImbuingPrice, goldTokenPrice);
                    earnOrLoose = (calculation < 0) ? "earn" : "loose";
                    Console.Clear();
                    CenteringWriteLine(title);
                    Console.WriteLine();
                    Console.WriteLine($"If you'll buy Gold Tokens you'll {earnOrLoose}: {Math.Abs(calculation)}");
                    Console.WriteLine();
                    Console.Write("Press button to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                default:
                    CriticalImbuing();
                    break;
            }
        }

        public static int ProtectiveCharmPrice()
        {
            Console.WriteLine();
            Console.Write($"Protective Charm Price {unit}: ");
            string input = Console.ReadLine();
            int protectiveCharmPrice = Convert.ToInt32(input);
            return protectiveCharmPrice;
        }

        private static int SabretoothPrice()
        {
            Console.WriteLine();
            Console.Write($"Sabretooth Price {unit}: ");
            string input = Console.ReadLine();
            int sabretoothPrice = Convert.ToInt32(input);
            return sabretoothPrice;
        }

        private static int VexclawTalonPrice()
        {
            Console.WriteLine();
            Console.Write($"Vexclav Talon Price {unit}: ");
            string input = Console.ReadLine();
            int vexclawTalonPrice = Convert.ToInt32(input);
            return vexclawTalonPrice;
        }

        private static int CriticalImbuingPrice()
        {
            int resultCriticalImbuing = 20 * protectiveCharmPrice + 25 * sabretoothPrice + 5 * vexclawTalonPrice;
            return resultCriticalImbuing;
        }
        #endregion

        #region Life Leech Imbuing
        private static void LifeLeechImbuing()
        {
            Console.Clear();
            CenteringWriteLine(title);
            Console.WriteLine();
            Console.WriteLine("1. Vampire Teeth Price");
            Console.WriteLine("2. Bloody Pincers Price");
            Console.WriteLine("3. Piece of Dead Brain Price");
            Console.WriteLine("4. Calculate...");
            Console.WriteLine();
            Console.Write("Choose item: ");
            var lifeLeechElementPrice = Console.ReadLine();
            switch (lifeLeechElementPrice)
            {
                case "1":
                    vampireTeethPrice = VampireTeethPrice();
                    LifeLeechImbuing();
                    break;

                case "2":
                    bloodyPincersPrice = BloodyPincersPrice();
                    LifeLeechImbuing();
                    break;

                case "3":
                    pieceOfDeadBrainPrice = PieceOfDeadBrainPrice();
                    LifeLeechImbuing();
                    break;

                case "4":
                     lifeLeechImbuingPrice = LifeLeechImbuingPrice();
                    calculation = Calculation(lifeLeechImbuingPrice, goldTokenPrice);
                    earnOrLoose = (calculation < 0) ? "earn" : "loose";
                    Console.Clear();
                    CenteringWriteLine(title);
                    Console.WriteLine();
                    Console.WriteLine($"If you'll buy Gold Tokens you'll {earnOrLoose}: {Math.Abs(calculation)}");
                    Console.WriteLine();
                    Console.Write("Press button to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                default:
                    LifeLeechImbuing();
                    break;
            }
        }

        private static int LifeLeechImbuingPrice()
        {
            int resultLifeLeechImbuing = 25 * vampireTeethPrice + 15 * bloodyPincersPrice + 5 * pieceOfDeadBrainPrice;
            return resultLifeLeechImbuing;
        }

        private static int VampireTeethPrice()
        {
            Console.WriteLine();
            Console.Write($"Vampire Teeth Price {unit}: ");
            string input = Console.ReadLine();
            int vampireTeethPrice = Convert.ToInt32(input);
            return vampireTeethPrice;
        }

        private static int BloodyPincersPrice()
        {
            Console.WriteLine();
            Console.Write($"Bloody Pincers Price {unit}: ");
            string input = Console.ReadLine();
            int bloodyPincersPrice = Convert.ToInt32(input);
            return bloodyPincersPrice;
        }
        private static int PieceOfDeadBrainPrice()
        {
            Console.WriteLine();
            Console.Write($"Piece of Dead Brain Price {unit}: ");
            string input = Console.ReadLine();
            int pieceOfDeadBrainPrice = Convert.ToInt32(input);
            return pieceOfDeadBrainPrice;
        }
        #endregion

        #region Mana Leech Imbuing
        private static void ManaLeechImbuing()
        {
            Console.Clear();
            CenteringWriteLine(title);
            Console.WriteLine();
            Console.WriteLine("1. Rope Belt Price");
            Console.WriteLine("2. Silencer Claws Price");
            Console.WriteLine("3. Grimeleech Wings Price");
            Console.WriteLine("4. Calculate...");
            Console.WriteLine();
            Console.Write("Choose item: ");
            var manaLeechElementPrice = Console.ReadLine();
            switch (manaLeechElementPrice)
            {
                case "1":
                    ropeBeltPrice = RopeBeltPrice();
                    ManaLeechImbuing();
                    break;

                case "2":
                    silencerClawsPrice = SilencerClawsPrice();
                    ManaLeechImbuing();
                    break;

                case "3":
                    grimeleechWingsPrice = GrimeleechWingsPrice();
                    ManaLeechImbuing();
                    break;

                case "4":
                    manaLeechImbuingPrice = ManaLeechImbuingPrice();
                    calculation = Calculation(manaLeechImbuingPrice, goldTokenPrice);
                    earnOrLoose = (calculation < 0) ? "earn" : "loose";
                    Console.Clear();
                    CenteringWriteLine(title);
                    Console.WriteLine();
                    Console.WriteLine($"If you'll buy Gold Tokens you'll {earnOrLoose}: {Math.Abs(calculation)}");
                    Console.WriteLine();
                    Console.Write("Press button to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                default:
                    ManaLeechImbuing();
                    break;
            }
        }

        private static int RopeBeltPrice()
        {
            Console.WriteLine();
            Console.Write($"Rope Belt Price {unit}: ");
            string input = Console.ReadLine();
            int ropeBeltPrice = Convert.ToInt32(input);
            return ropeBeltPrice;
        }

        private static int SilencerClawsPrice()
        {
            Console.WriteLine();
            Console.Write($"Silencer Claws Price {unit}: ");
            string input = Console.ReadLine();
            int silencerClawsPrice = Convert.ToInt32(input);
            return silencerClawsPrice;
        }
        private static int GrimeleechWingsPrice()
        {
            Console.WriteLine();
            Console.Write($"Grimeleech Wings Price {unit}: ");
            string input = Console.ReadLine();
            int grimeleechWingsPrice = Convert.ToInt32(input);
            return grimeleechWingsPrice;
        }


        private static int ManaLeechImbuingPrice()
        {
            int resultManaLeechImbuing = 25 * ropeBeltPrice + 25 * silencerClawsPrice + 5 * grimeleechWingsPrice;
            return resultManaLeechImbuing;
        }
        #endregion


        private static int Calculation(int itemsPrice, int goldTokenPrice)
        {
            int result = 6 * goldTokenPrice - itemsPrice;
            return result;
        }
        static void CenteringWriteLine(string writeLine)
        {
            Console.SetCursorPosition((Console.WindowWidth - writeLine.Length) / 2, Console.CursorTop); //centering text
            Console.WriteLine(writeLine);
        }
    }

}