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
        private formCritical criticalDisplay;
        private formManaLeech manaLeechDisplay;
        private formLifeLeech lifeLeechDisplay;

        private ICalculate basicImbuCalculate = new BasicImbuing();
        private ICalculate intricateImbuCalculate = new IntricateImbuing();
        private ICalculate powerfullImbuCalculate = new PowerfullImbuing();
        public Form1()
        {
            InitializeComponent();
            InitializeCriticalImbuement();
            InitializeManaLeechImbuement();
            InitializeLifeLeechImbuement();

        }
        #region Initialize Imbuement
        public void InitializeCriticalImbuement()
        {
            lblTitle.Text = "Critical Imbuement";
            formCritical critical_Display = new formCritical() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            critical_Display.FormBorderStyle = FormBorderStyle.None;

            this.criticalDisplay = critical_Display;
        }
        private void InitializeManaLeechImbuement()
        {
            lblTitle.Text = "Mana Leech Imbuement";
            formManaLeech manaLeech_Display = new formManaLeech() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            manaLeech_Display.FormBorderStyle = FormBorderStyle.None;

            this.manaLeechDisplay = manaLeech_Display;
        }
        private void InitializeLifeLeechImbuement()
        {
            lblTitle.Text = "Life Leech Imbuement";
            formLifeLeech lifeLeech_Display = new formLifeLeech() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lifeLeech_Display.FormBorderStyle = FormBorderStyle.None;

            this.lifeLeechDisplay = lifeLeech_Display;
        }
        #endregion

        #region Imbuing button click
        private void btnCritical_Click(object sender, EventArgs e)
        {
            btnCritical.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(this.criticalDisplay);
            this.criticalDisplay.Show();
        }

        private void btnManaLeech_Click(object sender, EventArgs e)
        {
            btnManaLeech.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(this.manaLeechDisplay);
            this.manaLeechDisplay.Show();
        }

        private void btnLifeLeech_Click(object sender, EventArgs e)
        {
            btnLifeLeech.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(lifeLeechDisplay);
            lifeLeechDisplay.Show();
        }
        #endregion

        #region Imbuing button leave
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
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtGoldTokenPrice_TextChanged(object sender, EventArgs e)
        {
            Values.GoldTokenPrice = int.TryParse(txtGoldTokenPrice.Text, out int value) ? value : 0;
            Messages.CountImbuFromGoldToken_ChangeText(
                Values.CriticalItems, basicImbuCalculate, intricateImbuCalculate, powerfullImbuCalculate,
                criticalDisplay.criticalItems, criticalDisplay.lblCriticalResult);

            Messages.CountImbuFromGoldToken_ChangeText(
               Values.ManaLeechItems, basicImbuCalculate, intricateImbuCalculate, powerfullImbuCalculate,
               manaLeechDisplay.manaLeechItems, manaLeechDisplay.lblManaLeechResult);

            Messages.CountImbuFromGoldToken_ChangeText(
               Values.LifeLeechItems, basicImbuCalculate, intricateImbuCalculate, powerfullImbuCalculate,
               lifeLeechDisplay.lifeLeechItems, lifeLeechDisplay.lblLifeLeechResult);
        }
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
