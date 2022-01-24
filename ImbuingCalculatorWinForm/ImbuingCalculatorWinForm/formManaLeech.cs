using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImbuingCalculatorWinForm
{
    public partial class formManaLeech : Form
    {
    private ICalculator calculator;
        private ICalculate basicImbuCalculate = new BasicImbuing();
        private ICalculate intricateImbuCalculate = new IntricateImbuing();
        private ICalculate powerfullImbuCalculate = new PowerfullImbuing();
        public formManaLeech()
        {
            InitializeComponent();
            calculator = new ManaLeechCalculator();
        }

        #region "X" buttons
        private void btnRopeBeltClear_Click(object sender, EventArgs e)
        {
            Values.RopeBeltPrice = 0;
            txtRopeBeltPrice.Text = string.Empty;

        }

        private void btnSilencerClawsClear_Click(object sender, EventArgs e)
        {
            Values.SilencerClawsPrice = 0;
            txtSilencerClawsPrice.Text = string.Empty;

        }

        private void btnGrimeleechWingsClear_Click(object sender, EventArgs e)
        {
            Values.GrimeleechWingsPrice = 0;
            txtGrimeleechWingsPrice.Text = string.Empty;

        }
        #endregion

        #region "txt field" change text
        private void txtRopeBeltPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRopeBeltPrice.Text, out int value))
            {
                Values.RopeBeltPrice = value;
                Values.ManaLeechItems[0] = Values.RopeBeltPrice;
            }
            if (Values.GoldTokenPrice == 0)
            {
                lblManaLeechResult.Text = "Gold Token field is empty...";
            }
            else if (Values.SilencerClawsPrice != 0 && Values.GrimeleechWingsPrice == 0)
            {
                var result = intricateImbuCalculate.Calculate(manaLeechlItems, Values.ManaLeechItems);
                if (result < 0)
                {
                    lblManaLeechResult.Text = $"If you buy 4 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblManaLeechResult.Text = $"If you buy 4 Gold Tokens you will SAVE {result}";


            }
            else if (Values.SilencerClawsPrice != 0 && Values.GrimeleechWingsPrice != 0)
            {
                var result = powerfullImbuCalculate.Calculate(manaLeechlItems, Values.ManaLeechItems);
                if (result < 0)
                {
                    lblManaLeechResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblManaLeechResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
            else
            {
                var result = basicImbuCalculate.Calculate(manaLeechlItems, Values.ManaLeechItems);
                if (result < 0)
                {
                    lblManaLeechResult.Text = $"If you buy 2 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblManaLeechResult.Text = $"If you buy 2 Gold Tokens you will SAVE {result}";
            }
        }

        private void txtSilencerClawsPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSilencerClawsPrice.Text, out int value))
            {
                Values.SilencerClawsPrice = value;
                Values.ManaLeechItems[1] = Values.SilencerClawsPrice;

            }
            if (Values.GoldTokenPrice == 0)
            {
                lblManaLeechResult.Text = "Gold Token field is empty...";
            }
            else if (Values.RopeBeltPrice == 0)
            {
                lblManaLeechResult.Text = "Protective Charm field is empty...";
            }
            else if (Values.GrimeleechWingsPrice != 0)
            {
                var result = powerfullImbuCalculate.Calculate(manaLeechlItems, Values.ManaLeechItems);
                if (result < 0)
                {
                    lblManaLeechResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblManaLeechResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
            else
            {
                var result = intricateImbuCalculate.Calculate(manaLeechlItems, Values.ManaLeechItems);
                if (result < 0)
                {
                    lblManaLeechResult.Text = $"If you buy 4 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblManaLeechResult.Text = $"If you buy 4 Gold Tokens you will SAVE {result}";
            }
        }

        private void txtGrimeleechWingsPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtGrimeleechWingsPrice.Text, out int value))
            {
                Values.GrimeleechWingsPrice = value;
                Values.ManaLeechItems[2] = Values.GrimeleechWingsPrice;

            }

            if (Values.GoldTokenPrice == 0)
            {
                lblManaLeechResult.Text = "Gold Token field is empty...";
            }
            else if (Values.RopeBeltPrice == 0)
            {
                lblManaLeechResult.Text = "Protective Charm field is empty...";
            }
            else if (Values.SilencerClawsPrice == 0)
            {
                lblManaLeechResult.Text = "Sabretooth field is empty...";

            }
            else
            {
                var result = powerfullImbuCalculate.Calculate(manaLeechlItems, Values.ManaLeechItems);
                if (result < 0)
                {
                    lblManaLeechResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblManaLeechResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
        }
        #endregion

        private void btnCalculateManaLeech_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = calculator.Calculate(Values.RopeBeltPrice, Values.SilencerClawsPrice, Values.GrimeleechWingsPrice);

                if (result < 0)
                {
                    txtManaLeechResult.ForeColor = Color.Green;
                    txtManaLeechResult.Text = $"If you will buy Gold Tokens you will save {Math.Abs(result)}";
                }
                else
                {
                    txtManaLeechResult.ForeColor = Color.Red;
                    txtManaLeechResult.Text = $"If you will buy Gold Tokens you will lose {result}";
                }
            }

            catch (Exception exception)
            {
                txtManaLeechResult.ForeColor = Color.Red;
                txtManaLeechResult.Text = $"{exception.Message}";
            }


        }
    }

    
}
