/*
    Name: Alex & Dan
    Date: Octber 10, 2015
    Purpose: Allows User to buy an iphone
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RobellusForm : Form
    {
        private decimal baseCostDecimal = 0m, accessoriesTotalDecimal = 0m, subTotalDecimal = 0m, tradeInDecimal = 0m,
            taxSumDecimal = 0m, totalSumDecimal = 0m;
        private const decimal IPHONE_6_PRICE_16_GB_DECIMAL = 749.00m, IPHONE_6_PRICE_64_GB_DECIMAL = 859.00m,
            IPHONE_6_PRICE_128_GB_DECIMAL = 969.00m,
            IPHONE_6s_PRICE_16_GB_DECIMAL = 969.00m, IPHONE_6s_PRICE_64_GB_DECIMAL = 1099.00m,
            IPHONE_6s_PRICE_128_GB_DECIMAL = 1229.00m,
            APPLE_CARE_DECIMAL = 99.00m, LEATHER_CASE_DECIMAL = 49.00m, SCREEN_PROTECTOR_DECIMAL = 29.00m,
            TAX_AMOUNT_DECIMAL = 0.13m;
        private Boolean iphoneAndCapacityPickedBoolean = false, validInput = false;
        public RobellusForm()
        {
            InitializeComponent();
        }
        private void RobellusForm_Load(object sender, EventArgs e)
        {
            clearForm();
            colourGroupBox.Enabled = false;
            capacityGroupBox.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            iphoneAndCapacityPickedBoolean = false;
            if (iPhone6RadioButton.Checked)
            {
                if (silverRadioButton.Checked || goldRadioButton.Checked || spaceGreyRadioButton.Checked)
                {
                    baseCostDecimal = 0;
                    if (capacity16RadioButton.Checked)
                    {
                        baseCostDecimal += IPHONE_6_PRICE_16_GB_DECIMAL;
                        iphoneAndCapacityPickedBoolean = true;
                    }
                    else if (capacity64RadioButton.Checked)
                    {
                        baseCostDecimal += IPHONE_6_PRICE_64_GB_DECIMAL;
                        iphoneAndCapacityPickedBoolean = true;
                    }
                    else if (capacity128RadioButton.Checked)
                    {
                        baseCostDecimal += IPHONE_6_PRICE_128_GB_DECIMAL;
                        iphoneAndCapacityPickedBoolean = true;
                    }
                    else
                    {
                        MessageBox.Show("You did not pick a capacity for your phones memory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You did not pick a colour", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (iPhone6SRadioButton.Checked)
            {
                if (silverRadioButton.Checked || goldRadioButton.Checked || spaceGreyRadioButton.Checked)
                {
                    baseCostDecimal = 0;
                    if (capacity16RadioButton.Checked)
                    {
                        baseCostDecimal += IPHONE_6_PRICE_16_GB_DECIMAL;
                        iphoneAndCapacityPickedBoolean = true;
                    }
                    else if (capacity64RadioButton.Checked)
                    {
                        baseCostDecimal += IPHONE_6_PRICE_64_GB_DECIMAL;
                        iphoneAndCapacityPickedBoolean = true;
                    }
                    else if (capacity128RadioButton.Checked)
                    {
                        baseCostDecimal += IPHONE_6_PRICE_128_GB_DECIMAL;
                        iphoneAndCapacityPickedBoolean = true;
                    }
                    else
                    {
                        MessageBox.Show("You did not pick a capacity for your phones memory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You did Not pick a colour", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You did not pick a phone to start with", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            basePriceTextBox.Text = baseCostDecimal.ToString("c");

            // if they did pick a phone and a colour and capacity
            if(iphoneAndCapacityPickedBoolean)
            {
                accessoriesTotalDecimal = 0;
                if(appleCareCheckBox.Checked)
                {
                    accessoriesTotalDecimal += APPLE_CARE_DECIMAL;
                }
                if(leatherCaseCheckBox.Checked)
                {
                    accessoriesTotalDecimal += LEATHER_CASE_DECIMAL;
                }
                if(screenProtectorCheckBox.Checked)
                {
                    accessoriesTotalDecimal += SCREEN_PROTECTOR_DECIMAL;
                }
                accessoriesTextBox.Text = accessoriesTotalDecimal.ToString("c");
            }

            //try to change the trade in string value into a decimal
            try
            {
                tradeInDecimal = Decimal.Parse(tradeInTextBox.Text, NumberStyles.Currency);
                if (tradeInDecimal > 0)
                    validInput = true;
                else
                    MessageBox.Show("The Trade-In needs to be equal to or bigger then 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validInput = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you put in the trade-in is not valid, please try another number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validInput)
            {
                tradeInTextBox.Text = tradeInDecimal.ToString("c");
                subTotalDecimal = baseCostDecimal - tradeInDecimal;
                subtotalTextBox.Text = subTotalDecimal.ToString("c");
                taxSumDecimal = subTotalDecimal * TAX_AMOUNT_DECIMAL;
                taxTextBox.Text = taxSumDecimal.ToString("c");
                totalSumDecimal = subTotalDecimal + taxSumDecimal;
                totalTextBox.Text = totalSumDecimal.ToString("c");
            }
        }

        private void clearForm()
        {
            iPhone6RadioButton.Checked = false;
            iPhone6SRadioButton.Checked = false;
            spaceGreyRadioButton.Checked = false;
            silverRadioButton.Checked = false;
            goldRadioButton.Checked = false;
            capacity16RadioButton.Checked = false;
            capacity64RadioButton.Checked = false;
            capacity128RadioButton.Checked = false;
            appleCareCheckBox.Checked = false;
            leatherCaseCheckBox.Checked = false;
            screenProtectorCheckBox.Checked = false;
            basePriceTextBox.Text = 0.ToString("c");
            accessoriesTextBox.Text = 0.ToString("c");
            tradeInTextBox.Text = 0.ToString("c");
            subtotalTextBox.Text = 0.ToString("c");
            taxTextBox.Text = 0.ToString("c");
            totalTextBox.Text = 0.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void iPhone6RadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            colourGroupBox.Enabled = true;
            capacityGroupBox.Enabled = true;
        }

        private void iPhone6SRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            colourGroupBox.Enabled = true;
            capacityGroupBox.Enabled = true;
        }

        private void spaceGreyRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (iPhone6RadioButton.Checked)
            {
                iPhonePictureBox.Image = WindowsFormsApplication1.Properties.Resources.Iphone6InSpaceGrey;
            }
            if (iPhone6SRadioButton.Checked)
            {
                iPhonePictureBox.Image = WindowsFormsApplication1.Properties.Resources.Iphone6sInSpaceGrey;
            }
        }

        private void goldRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (iPhone6RadioButton.Checked)
            {
                iPhonePictureBox.Image = WindowsFormsApplication1.Properties.Resources.Iphone6Gold;
            }
            if (iPhone6SRadioButton.Checked)
            {
                iPhonePictureBox.Image = WindowsFormsApplication1.Properties.Resources.Iphone6sGold;
            }
        }

        private void silverRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (iPhone6RadioButton.Checked)
            {
                iPhonePictureBox.Image = WindowsFormsApplication1.Properties.Resources.Iphone6Silver;
            }
            if (iPhone6SRadioButton.Checked)
            {
                iPhonePictureBox.Image = WindowsFormsApplication1.Properties.Resources.Iphone6sInSilver;
            }
        }
    }
}
