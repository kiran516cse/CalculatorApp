using CalculatorApp.BAL;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        #region --- Properties ---

        CalculatorBAL calculatorBAL;

        //  User is adding a new number?
        private bool isNewNumber = true;

        //  Maximum Decimal Places
        private const int maxDecimalPlaces = 5;

        #endregion --- Properties ---

        #region --- Constructor ---

        public Calculator()
        {
            InitializeComponent();

            calculatorBAL = new CalculatorBAL();
        }

        #endregion  --- Constructor ---

        #region --- Button Click Events ---

        private void OperationButton_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// When user presses the numbers on the Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (isNewNumber)
            {
                txtBoxDisplayData.Text = buttonText;
                isNewNumber = false;
            }
            else
            {
                if (txtBoxDisplayData.Text == "0" && buttonText != ".")
                {
                    txtBoxDisplayData.Text = buttonText;
                }
                else
                {
                    if (buttonText == "." && !txtBoxDisplayData.Text.Contains("."))
                    {
                        txtBoxDisplayData.Text += buttonText;
                    }
                    else if (buttonText != ".")
                    {
                        // Check if adding the digit exceeds the maximum number of digits after the decimal point
                        int decimalIndex = txtBoxDisplayData.Text.IndexOf(".");
                        if (decimalIndex != -1 && txtBoxDisplayData.Text.Length - decimalIndex > maxDecimalPlaces)
                        {
                            // If the maximum number of digits after the decimal point is reached, do nothing
                            return;
                        }
                        txtBoxDisplayData.Text += buttonText;
                    }
                }
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
        }

        #endregion  --- Button Click Events ---


        #region --- Private API's ---



        #endregion  --- Private API's ---
    }
}
