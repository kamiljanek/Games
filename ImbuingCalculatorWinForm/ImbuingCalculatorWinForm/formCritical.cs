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
        private string goldTokenPrice { get; set; }
        public formCritical(string goldTokenPrice)
        {
            InitializeComponent();
            calculator = new CriticalCalculator();
        }


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
        private void txtProtectiveCharmPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtProtectiveCharmPrice.Text, out int value))
            {
                Values.ProtectiveCharmPrice = value;
            }
        }

        private void txtSabretoothPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSabretoothPrice.Text, out int value))
            {
                Values.SabretoothPrice = value;
            }
        }

        private void txtVexclawTalonPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtVexclawTalonPrice.Text, out int value))
            {
                Values.VexclawTokenPrice = value;
            }
        }

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
