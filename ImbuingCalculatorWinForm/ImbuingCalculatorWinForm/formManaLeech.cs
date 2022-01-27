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
        private ICalculate basicImbuCalculate = new BasicImbuing();
        private ICalculate intricateImbuCalculate = new IntricateImbuing();
        private ICalculate powerfullImbuCalculate = new PowerfullImbuing();

        public formManaLeech()
        {
            InitializeComponent();
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
            Values.ManaLeechItems[0] = int.TryParse(txtRopeBeltPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblManaLeechResult);
            }

            else if (Values.ManaLeechItems[0] != 0 && Values.ManaLeechItems[1] != 0 && Values.ManaLeechItems[2] == 0)
            {
                var result = intricateImbuCalculate.Calculate(manaLeechItems, Values.ManaLeechItems);
                intricateImbuCalculate.IfStatement(result, lblManaLeechResult);
            }

            else if (Values.ManaLeechItems[0] != 0 && Values.ManaLeechItems[1] != 0 && Values.ManaLeechItems[2] != 0)
            {
                var result = powerfullImbuCalculate.Calculate(manaLeechItems, Values.ManaLeechItems);
                powerfullImbuCalculate.IfStatement(result, lblManaLeechResult);
            }

            else
            {
                if (Values.ManaLeechItems[0] != 0)
                {
                    var result = basicImbuCalculate.Calculate(manaLeechItems, Values.ManaLeechItems);
                    basicImbuCalculate.IfStatement(result, lblManaLeechResult);
                }
                else
                {
                    Messages.WrongInputMessage(lblManaLeechResult);
                }
            }
        }

        private void txtSilencerClawsPrice_TextChanged(object sender, EventArgs e)
        {
            Values.ManaLeechItems[1] = int.TryParse(txtSilencerClawsPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblManaLeechResult);
            }

            else if (Values.ManaLeechItems[0] == 0 || Values.ManaLeechItems[1] == 0)
            {
                Messages.WrongInputMessage(lblManaLeechResult);
            }

            else if (Values.ManaLeechItems[0] != 0 && Values.ManaLeechItems[1] != 0 && Values.ManaLeechItems[2] != 0)
            {
                var result = powerfullImbuCalculate.Calculate(manaLeechItems, Values.ManaLeechItems);
                powerfullImbuCalculate.IfStatement(result, lblManaLeechResult);
            }

            else
            {
                var result = intricateImbuCalculate.Calculate(manaLeechItems, Values.ManaLeechItems);
                intricateImbuCalculate.IfStatement(result, lblManaLeechResult);
            }
        }

        private void txtGrimeleechWingsPrice_TextChanged(object sender, EventArgs e)
        {
            Values.ManaLeechItems[2] = int.TryParse(txtGrimeleechWingsPrice.Text, out int value) ? value : 0;

            if (Values.GoldTokenPrice == 0)
            {
                Messages.GoldTokenEmpty(lblManaLeechResult);
            }
            else if (Values.ManaLeechItems[0] == 0 || Values.ManaLeechItems[1] == 0 || Values.ManaLeechItems[2] == 0)
            {
                Messages.WrongInputMessage(lblManaLeechResult);
            }

            else
            {
                var result = powerfullImbuCalculate.Calculate(manaLeechItems, Values.ManaLeechItems);
                powerfullImbuCalculate.IfStatement(result, lblManaLeechResult);
            }
        }
        #endregion


    }

    
}
