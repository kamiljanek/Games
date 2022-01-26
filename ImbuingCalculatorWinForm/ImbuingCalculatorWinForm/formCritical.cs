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
            Values.CriticalItems[0] = int.TryParse(txtProtectiveCharmPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblCriticalResult);
            }

            else if (Values.CriticalItems[0] != 0 && Values.CriticalItems[1] != 0 && Values.CriticalItems[2] == 0)
            {
                var result = intricateImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                intricateImbuCalculate.IfStatement(result, lblCriticalResult);
            }

            else if (Values.CriticalItems[0] != 0 && Values.CriticalItems[1] != 0 && Values.CriticalItems[2] != 0)
            {
                var result = powerfullImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                powerfullImbuCalculate.IfStatement(result, lblCriticalResult);
            }

            else
            {
                if (Values.CriticalItems[0] != 0)
                {
                    var result = basicImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                    basicImbuCalculate.IfStatement(result, lblCriticalResult);
                }
                else
                {
                    Messages.WrongInputMessage(lblCriticalResult);
                }
            }
        }


        private void txtSabretoothPrice_TextChanged(object sender, EventArgs e)
        {
            Values.CriticalItems[1] = int.TryParse(txtSabretoothPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblCriticalResult);
            }

            else if (Values.CriticalItems[0] == 0 || Values.CriticalItems[1] == 0)
            {
                Messages.WrongInputMessage(lblCriticalResult);
            }

            else if (Values.CriticalItems[0] != 0 && Values.CriticalItems[1] != 0 && Values.CriticalItems[2] != 0)
            {
                var result = powerfullImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                powerfullImbuCalculate.IfStatement(result, lblCriticalResult);
            }

            else
            {
                var result = intricateImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                intricateImbuCalculate.IfStatement(result, lblCriticalResult);
            }
        }

        private void txtVexclawTalonPrice_TextChanged(object sender, EventArgs e)
        {
            Values.CriticalItems[2] = int.TryParse(txtVexclawTalonPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblCriticalResult);
            }
            else if (Values.CriticalItems[0] == 0 || Values.CriticalItems[1] == 0 || Values.CriticalItems[2] == 0)
            {
                Messages.WrongInputMessage(lblCriticalResult);
            }

            else
            {
                var result = powerfullImbuCalculate.Calculate(criticalItems, Values.CriticalItems);
                powerfullImbuCalculate.IfStatement(result, lblCriticalResult);
            }
        }
        #endregion

    }
}

