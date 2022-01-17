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


        public formLifeLeech()
        {
            InitializeComponent();
            calculator = new LifeLeechCalculator();
        }


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
        private void txtVampireTeethPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtVampireTeethPrice.Text, out int value))
            {
                Values.VampireTeethPrice = value;
            }
        }

        private void txtBloodyPincersPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBloodyPincersPrice.Text, out int value))
            {
                Values.BloodyPincersPrice = value;
            }
        }

        private void txtPieceOfDeadBrainPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPieceOfDeadBrainPrice.Text, out int value))
            {
                Values.PieceOfDeadBrainPrice = value;
            }
        }


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
