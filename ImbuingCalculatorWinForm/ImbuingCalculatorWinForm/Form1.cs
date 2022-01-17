using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ImbuingCalculatorWinForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void btnCritical_Click(object sender, EventArgs e)
        {
            btnCritical.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Critical Imbuement";
            this.pnlFormLoader.Controls.Clear();
            formCritical critical_Vrb = new formCritical(txtGoldTokenPrice.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            critical_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(critical_Vrb);
            critical_Vrb.Show();

        }

        private void btnManaLeech_Click(object sender, EventArgs e)
        {
            btnManaLeech.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Mana Leech Imbuement";
            this.pnlFormLoader.Controls.Clear();
            formManaLeech manaLeech_Vrb = new formManaLeech() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            manaLeech_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(manaLeech_Vrb);
            manaLeech_Vrb.Show();

        }

        private void btnLifeLeech_Click(object sender, EventArgs e)
        {
            btnLifeLeech.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Life Leech Imbuement";
            this.pnlFormLoader.Controls.Clear();
            formLifeLeech lifeLeech_Vrb = new formLifeLeech() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lifeLeech_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(lifeLeech_Vrb);
            lifeLeech_Vrb.Show();
        }



        private void btnCritical_Leave(object sender, EventArgs e)
        {
            btnCritical.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnManaLeech_Leave(object sender, EventArgs e)
        {
            btnManaLeech.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnLifeLeech_Leave(object sender, EventArgs e)
        {
            btnLifeLeech.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtGoldTokenPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtGoldTokenPrice.Text, out int value))
            {
                Values.GoldTokenPrice = value;
            }
        }
    }
    public static class Values
    {
        public static int GoldTokenPrice = 0;
        public static int ProtectiveCharmPrice = 0;
        public static int SabretoothPrice = 0;
        public static int VexclawTokenPrice = 0;
        public static int RopeBeltPrice = 0;
        public static int SilencerClawsPrice = 0;
        public static int GrimeleechWingsPrice = 0;
        public static int VampireTeethPrice = 0;
        public static int BloodyPincersPrice = 0;
        public static int PieceOfDeadBrainPrice = 0;

    }

    interface ICalculator
    {
        int Calculate(int firstItemPrice, int secondItemPrice, int thirdItemPrice);


    }
    public class CriticalCalculator : ICalculator
    {
        public int Calculate(int firstItemPrice, int secondItemPrice, int thirdItemPrice)
        {
            if (firstItemPrice == 0 || secondItemPrice == 0 || thirdItemPrice == 0 || Values.GoldTokenPrice == 0)
            {
                throw new Exception("Item price have to be higher than 0");
            }

            var result = 6 * Values.GoldTokenPrice - (20 * firstItemPrice + 25 * secondItemPrice + 5 * thirdItemPrice);
            return result;
        }
    }
    public class ManaLeechCalculator : ICalculator
    {
        public int Calculate(int firstItemPrice, int secondItemPrice, int thirdItemPrice)
        {
            if (firstItemPrice == 0 || secondItemPrice == 0 || thirdItemPrice == 0 || Values.GoldTokenPrice == 0)
            {
                throw new Exception("Item price have to be higher than 0");
            }

            var result = 6 * Values.GoldTokenPrice - (25 * firstItemPrice + 25 * secondItemPrice + 5 * thirdItemPrice);
            return result;
        }
    }
    public class LifeLeechCalculator : ICalculator
    {
        public int Calculate(int firstItemPrice, int secondItemPrice, int thirdItemPrice)
        {
            if (firstItemPrice == 0 || secondItemPrice == 0 || thirdItemPrice == 0 || Values.GoldTokenPrice == 0)
            {
                throw new Exception("Item price have to be higher than 0");
            }

            var result = 6 * Values.GoldTokenPrice - (25 * firstItemPrice + 15 * secondItemPrice + 5 * thirdItemPrice);
            return result;
        }
    }
}
