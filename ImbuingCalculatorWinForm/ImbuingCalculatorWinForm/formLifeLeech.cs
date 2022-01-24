using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImbuingCalculatorWinForm
{
    public partial class formLifeLeech : Form
    {
        private ICalculator calculator;
        private ICalculate basicImbuCalculate = new BasicImbuing();
        private ICalculate intricateImbuCalculate = new IntricateImbuing();
        private ICalculate powerfullImbuCalculate = new PowerfullImbuing();

        public formLifeLeech()
        {
            InitializeComponent();
            calculator = new LifeLeechCalculator();
        }

        #region "X" buttons
        private void btnVampireTeethClear_Click(object sender, EventArgs e)
        {
            Values.VampireTeethPrice = 0;
            txtVampireTeethPrice.Text = string.Empty;
        }

        private void btnBloodyPincersClear_Click(object sender, EventArgs e)
        {
            Values.BloodyPincersPrice = 0;
            txtBloodyPincersPrice.Text = string.Empty;
        }

        private void btnPieceOfDeadBrainClear_Click(object sender, EventArgs e)
        {
            Values.PieceOfDeadBrainPrice = 0;
            txtPieceOfDeadBrainPrice.Text = string.Empty;
        }
        #endregion
        
        #region "txt field" change text
        private void txtVampireTeethPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtVampireTeethPrice.Text, out int value))
            {
                Values.VampireTeethPrice = value;
                Values.LifeLeechItems[0] = Values.VampireTeethPrice;
            }
            if (Values.GoldTokenPrice == 0)
            {
                lblLifeLeechResult.Text = "Gold Token field is empty...";
            }
            else if (Values.BloodyPincersPrice != 0 && Values.PieceOfDeadBrainPrice == 0)
            {
                var result = intricateImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                if (result < 0)
                {
                    lblLifeLeechResult.Text = $"If you buy 4 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblLifeLeechResult.Text = $"If you buy 4 Gold Tokens you will SAVE {result}";


            }
            else if (Values.BloodyPincersPrice != 0 && Values.PieceOfDeadBrainPrice != 0)
            {
                var result = powerfullImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                if (result < 0)
                {
                    lblLifeLeechResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblLifeLeechResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
            else
            {
                var result = basicImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                if (result < 0)
                {
                    lblLifeLeechResult.Text = $"If you buy 2 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblLifeLeechResult.Text = $"If you buy 2 Gold Tokens you will SAVE {result}";
            }
        }

        private void txtBloodyPincersPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBloodyPincersPrice.Text, out int value))
            {
                Values.BloodyPincersPrice = value;
                Values.LifeLeechItems[1] = Values.BloodyPincersPrice;
            }
            if (Values.GoldTokenPrice == 0)
            {
                lblLifeLeechResult.Text = "Gold Token field is empty...";
            }
            else if (Values.VampireTeethPrice == 0)
            {
                lblLifeLeechResult.Text = "Protective Charm field is empty...";
            }
            else if (Values.PieceOfDeadBrainPrice != 0)
            {
                var result = powerfullImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                if (result < 0)
                {
                    lblLifeLeechResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblLifeLeechResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
            else
            {
                var result = intricateImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                if (result < 0)
                {
                    lblLifeLeechResult.Text = $"If you buy 4 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblLifeLeechResult.Text = $"If you buy 4 Gold Tokens you will SAVE {result}";
            }
        }

        private void txtPieceOfDeadBrainPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPieceOfDeadBrainPrice.Text, out int value))
            {
                Values.PieceOfDeadBrainPrice = value;
                Values.LifeLeechItems[2] = Values.PieceOfDeadBrainPrice;
            }

            if (Values.GoldTokenPrice == 0)
            {
                lblLifeLeechResult.Text = "Gold Token field is empty...";
            }
            else if (Values.VampireTeethPrice == 0)
            {
                lblLifeLeechResult.Text = "Protective Charm field is empty...";
            }
            else if (Values.BloodyPincersPrice == 0)
            {
                lblLifeLeechResult.Text = "Sabretooth field is empty...";

            }
            else
            {
                var result = powerfullImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                if (result < 0)
                {
                    lblLifeLeechResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblLifeLeechResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
        }
        #endregion

        private void btnCalculateLifeLeech_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = calculator.Calculate(Values.VampireTeethPrice, Values.BloodyPincersPrice, Values.PieceOfDeadBrainPrice);

                if (result < 0)
                {
                    txtLifeLeechResult.ForeColor = Color.Green;
                    txtLifeLeechResult.Text = $"If you will buy Gold Tokens you will save {Math.Abs(result)}";
                }
                else
                {
                    txtLifeLeechResult.ForeColor = Color.Red;
                    txtLifeLeechResult.Text = $"If you will buy Gold Tokens you will lose {result}";
                }
            }

            catch (Exception exception)
            {
                txtLifeLeechResult.ForeColor = Color.Red;
                txtLifeLeechResult.Text = $"{exception.Message}";
            }

        }

    }
}
