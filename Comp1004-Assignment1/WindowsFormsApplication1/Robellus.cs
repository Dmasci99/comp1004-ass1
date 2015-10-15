using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RobellusForm : Form
    {
        private decimal basePriceDecimal = 0, accessoryPriceDecimal = 0, tradeInDecimal = 0, subTotalDecimal = 0,
            taxAmountDecimal = 0, totalDecimal = 0;
        private const decimal TAX_DECIMAL = 0.13m, MONEY_FORMAT_DECIMAL = 0;


        public RobellusForm()
        {
            InitializeComponent();
            
        }
        private void RobellusForm_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        private void iPhone6RadioButton_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, System.EventArgs e)
        {

        }

        private void clearButton_Click(object sender, System.EventArgs e)
        {
            clearForm();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void leatherCaseCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void screenProtectorCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void clearForm()
        {
            iPhone6RadioButton.Checked = false;
            iPhone6SRadioButton.Checked = false;
            spaceGreyRadioButton.Checked = false;
            silverRadioButton.Checked = false;
            goldRadioButton.Checked = false;
            capacity64RadioButton.Checked = false;
            capacity16RadioButton.Checked = false;
            capacity128RadioButton.Checked = false;
            appleCareCheckBox.Checked = false;
            leatherCaseCheckBox.Checked = false;
            screenProtectorCheckBox.Checked = false;
            basePriceTextBox.Text = MONEY_FORMAT_DECIMAL.ToString("c");
            accessoriesTextBox.Text = MONEY_FORMAT_DECIMAL.ToString("c");
            tradeInTextBox.Text = MONEY_FORMAT_DECIMAL.ToString("c");
            taxTextBox.Text = MONEY_FORMAT_DECIMAL.ToString("c");
            totalTextBox.Text = MONEY_FORMAT_DECIMAL.ToString("c");
        }
    }
}
