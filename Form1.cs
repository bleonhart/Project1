using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Project1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            outputBox.ReadOnly = true;

            decimalButton.Checked = true;
            inputDecimalButton.Checked = true;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Dictionary<RadioButton, int> inputBases = new()
            {
                {inputBinaryButton, 2 },
                {inputOctalButton, 8 },
                {inputDecimalButton, 10 },
                {inputHexButton, 16 }
            };

            Dictionary<RadioButton, int> numberBases = new Dictionary<RadioButton, int>()
            {
                {binaryButton, 2 },
                {octalButton, 8 },
                {decimalButton, 10 },
                {hexButton, 16 }
            };

            int inputBase = 0;

            foreach (var item in inputBases)
            {
                if(item.Key.Checked)
                {
                    inputBase = item.Value;
                    break;
                }
            }

            if (inputBase == 0)
            {
                MessageBox.Show("Please select an input base.");
                return;
            }

            long number;

            try
            {
                number = Convert.ToInt64(inputBox.Text.Trim(), inputBase);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number for the selected base.");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number is too large.");
                return;
            }
            foreach (var item in numberBases)
            {
                if (item.Key.Checked)
                {
                    int selectedBase = item.Value;

                    outputBox.Text = Convert.ToString(number, selectedBase).ToUpperInvariant();

                    return;
                }
            }

            MessageBox.Show("Please select a number system.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
