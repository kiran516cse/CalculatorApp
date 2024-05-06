using CalculatorApp.Interfaces;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        #region --- Properties ---

        //  Define the calculator variable
        private readonly ICalculator calculator;

        //  User is adding a new number?
        private bool isNewNumber = true;

        //  Operation value like +, -, /, *
        private string operation = "";

        //  Maximum Decimal Places
        private const int maxDecimalPlaces = 5;

        //  Previous number
        private double previousNumber = 0;

        #endregion --- Properties ---

        #region --- Constructor ---

        public Calculator(ICalculator calculator)
        {
            InitializeComponent();

            this.calculator = calculator;   //  Assign the calculator instance to local variable instance
        }

        #endregion  --- Constructor ---

        #region --- Button Click Events ---

        /// <summary>
        /// When user clicks on four basic arithemetic operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (!isNewNumber)
            {
                if (!string.IsNullOrEmpty(operation))
                {
                    Calculate();
                }

                previousNumber = double.Parse(txtBoxDisplayData.Text);
                operation = buttonText;
                isNewNumber = true;
            }
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

        /// <summary>
        /// When user clicks on th Equals button then actual calculation will takes place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                Calculate();
                operation = string.Empty;
            }
        }

        /// <summary>
        /// Clears the text from the Display Text Box and makes other properties to default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtBoxDisplayData.Text = "0";
            isNewNumber = true;
            operation = string.Empty;
            previousNumber = 0;
        }

        #endregion  --- Button Click Events ---


        #region --- Private API's ---

        /// <summary>
        /// Calculation logic for 4 arithemtic operations
        /// </summary>
        private void Calculate()
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = calculator.Add(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    break;

                case "-":
                    result = calculator.Subtract(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    break;

                case "�~":
                    result = calculator.Multiply(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    break;

                case "/":
                    result = calculator.Divide(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    break;
            }

            txtBoxDisplayData.Text = result.ToString();
            isNewNumber = true;
        }

        #endregion  --- Private API's ---
    }
}
