using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImbuingCalculatorWinForm
{
    public partial class formCritical : Form
    {
        private ICalculator calculator;
        private ICalculate basicImbuCalculate = new BasicImbuing();
        private ICalculate intricateImbuCalculate = new IntricateImbuing();
        private ICalculate powerfullImbuCalculate = new PowerfullImbuing();

        public formCritical()
        {
            InitializeComponent();
            calculator = new CriticalCalculator();

        }



        #region "X" buttons
        private void btnProtectiveCharmClear_Click(object sender, EventArgs e)
        {
            Values.ProtectiveCharmPrice = 0;
            txtProtectiveCharmPrice.Text = string.Empty;

        }

        private void btnSabretoothClear_Click(object sender, EventArgs e)
        {
            Values.SabretoothPrice = 0;
            txtSabretoothPrice.Text = string.Empty;

        }

        private void btnVexclawTalonClear_Click(object sender, EventArgs e)
        {
            Values.VexclawTokenPrice = 0;
            txtVexclawTalonPrice.Text = string.Empty;

        }
        #endregion

        #region "txt field" change text 
        private void txtProtectiveCharmPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtProtectiveCharmPrice.Text, out int value))
            {
                Values.ProtectiveCharmPrice = value;
                Values.CriticalItems[0] = Values.ProtectiveCharmPrice;
            }
            if (Values.GoldTokenPrice == 0)
            {
                lblCriticalResult.Text = "Gold Token field is empty...";
            }
            else if (Values.SabretoothPrice != 0 && Values.VexclawTokenPrice == 0)
            {
                var result = intricateImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                if (result < 0)
                {
                    lblCriticalResult.Text = $"If you buy 4 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblCriticalResult.Text = $"If you buy 4 Gold Tokens you will SAVE {result}";


            }
            else if (Values.SabretoothPrice != 0 && Values.VexclawTokenPrice != 0)
            {
                var result = powerfullImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                if (result < 0)
                {
                    lblCriticalResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblCriticalResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
            else
            {
                var result = basicImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                if (result < 0)
                {
                    lblCriticalResult.Text = $"If you buy 2 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblCriticalResult.Text = $"If you buy 2 Gold Tokens you will SAVE {result}";
            }
        }

        private void txtSabretoothPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSabretoothPrice.Text, out int value))
            {
                Values.SabretoothPrice = value;
                Values.CriticalItems[1] = Values.SabretoothPrice;
            }
            if (Values.GoldTokenPrice == 0)
            {
                lblCriticalResult.Text = "Gold Token field is empty...";
            }
            else if (Values.ProtectiveCharmPrice == 0)
            {
                lblCriticalResult.Text = "Protective Charm field is empty...";
            }
            else if (Values.VexclawTokenPrice != 0)
            {
                var result = powerfullImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                if (result < 0)
                {
                    lblCriticalResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblCriticalResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
            else
            {
                var result = intricateImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                if (result < 0)
                {
                    lblCriticalResult.Text = $"If you buy 4 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblCriticalResult.Text = $"If you buy 4 Gold Tokens you will SAVE {result}";
            }
        }

        private void txtVexclawTalonPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtVexclawTalonPrice.Text, out int value))
            {
                Values.VexclawTokenPrice = value;
                Values.CriticalItems[2] = Values.VexclawTokenPrice;
            }

            if (Values.GoldTokenPrice == 0)
            {
                lblCriticalResult.Text = "Gold Token field is empty...";
            }
            else if (Values.ProtectiveCharmPrice == 0)
            {
                lblCriticalResult.Text = "Protective Charm field is empty...";
            }
            else if (Values.SabretoothPrice == 0)
            {
                lblCriticalResult.Text = "Sabretooth field is empty...";

            }
            else
            {
                var result = powerfullImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                if (result < 0)
                {
                    lblCriticalResult.Text = $"If you buy 6 Gold Tokens you will LOSE {Math.Abs(result)}";
                }
                else
                    lblCriticalResult.Text = $"If you buy 6 Gold Tokens you will SAVE {result}";
            }
        }
        #endregion


        private void btnCalculateCritical_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = calculator.Calculate(Values.ProtectiveCharmPrice, Values.SabretoothPrice, Values.VexclawTokenPrice);

                if (result < 0)
                {
                    txtCriticalResult.ForeColor = Color.Green;
                    txtCriticalResult.Text = $"If you will buy Gold Tokens you will save {Math.Abs(result)}";
                }
                else
                {
                    txtCriticalResult.ForeColor = Color.Red;
                    txtCriticalResult.Text = $"If you will buy Gold Tokens you will lose {result}";
                }
            }

            catch (Exception exception)
            {
                txtCriticalResult.ForeColor = Color.Red;
                txtCriticalResult.Text = $"{exception.Message}";
            }


        }

    }
}
