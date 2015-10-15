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
        public RobellusForm()
        {
            InitializeComponent();
        }
        private void RobellusForm_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
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
            appleCareRadioButton.Checked = false;
            leatherCaseRadioButton.Checked = false;
            screenProtectorRadioButton.Checked = false;
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
    }
}
