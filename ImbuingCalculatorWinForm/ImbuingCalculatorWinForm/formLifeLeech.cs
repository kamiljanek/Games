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
            Values.LifeLeechItems[0] = int.TryParse(txtVampireTeethPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblLifeLeechResult);
            }

            else if (Values.LifeLeechItems[0] != 0 && Values.LifeLeechItems[1] != 0 && Values.LifeLeechItems[2] == 0)
            {
                var result = intricateImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                intricateImbuCalculate.IfStatement(result, lblLifeLeechResult);
            }

            else if (Values.LifeLeechItems[0] != 0 && Values.LifeLeechItems[1] != 0 && Values.LifeLeechItems[2] != 0)
            {
                var result = powerfullImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                powerfullImbuCalculate.IfStatement(result, lblLifeLeechResult);
            }

            else
            {
                if (Values.LifeLeechItems[0] != 0)
                {
                    var result = basicImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                    basicImbuCalculate.IfStatement(result, lblLifeLeechResult);
                }
                else
                {
                    Messages.WrongInputMessage(lblLifeLeechResult);
                }
            }
        }

        private void txtBloodyPincersPrice_TextChanged(object sender, EventArgs e)
        {
            Values.LifeLeechItems[1] = int.TryParse(txtBloodyPincersPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblLifeLeechResult);
            }

            else if (Values.LifeLeechItems[0] == 0 || Values.LifeLeechItems[1] == 0)
            {
                Messages.WrongInputMessage(lblLifeLeechResult);
            }

            else if (Values.LifeLeechItems[0] != 0 && Values.LifeLeechItems[1] != 0 && Values.LifeLeechItems[2] != 0)
            {
                var result = powerfullImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                powerfullImbuCalculate.IfStatement(result, lblLifeLeechResult);
            }

            else
            {
                var result = intricateImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                intricateImbuCalculate.IfStatement(result, lblLifeLeechResult);
            }
        }

        private void txtPieceOfDeadBrainPrice_TextChanged(object sender, EventArgs e)
        {
            Values.LifeLeechItems[2] = int.TryParse(txtPieceOfDeadBrainPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblLifeLeechResult);
            }
            else if (Values.LifeLeechItems[0] == 0 || Values.LifeLeechItems[1] == 0 || Values.LifeLeechItems[2] == 0)
            {
                Messages.WrongInputMessage(lblLifeLeechResult);
            }

            else
            {
                var result = powerfullImbuCalculate.Calculate(lifeLeechItems, Values.LifeLeechItems);
                powerfullImbuCalculate.IfStatement(result, lblLifeLeechResult);
            }
        }
        #endregion

      

    }
}
