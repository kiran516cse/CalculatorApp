using CalculatorApp.Interfaces;
using log4net;
using log4net.Config;

namespace CalculatorApp
{
    /// <summary>
    /// Calculator functionality is basically reqired for any kind of calculations.
    /// So, I have designed the Calculator to extend further for other calculators like Scientific Calculator, etc.,
    /// Also, Now I used an Dependency Injection where user can able to add the features as plugins / components and can able to initialize according to their needs.
    /// However for example I had introduced an interface for Scientific Calculator to add in the Calculator but the UI is not designed for it.
    /// </summary>
    public partial class Calculator : Form
    {
        #region --- Properties ---

        //  Define the calculator variable
        private readonly ICalculator calculator;

        //  Logging for Calculator application
        private static readonly ILog log = LogManager.GetLogger(typeof(Calculator));

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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="calculator"></param>
        public Calculator(ICalculator calculator)
        {
            XmlConfigurator.Configure();
            log.Info("Calculator application started.");

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
            log.Debug("Entered - User has clicked on the arithemetic operation button");

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

            log.Debug("Exited - User has clicked on the arithemetic operation button");
        }

        /// <summary>
        /// When user presses the numbers on the Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            log.Debug("Entered - User has clicked on the number button");

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

            log.Debug("Exited - User has clicked on the number button");
        }

        /// <summary>
        /// When user clicks on th Equals button then actual calculation will takes place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            log.Debug("Started to Calculate the calculations after clicking the Equals button");

            if (!isNewNumber)
            {
                Calculate();
                operation = string.Empty;
            }

            log.Debug("Completed to Calculate the calculations after clicking the Equals button");
        }

        /// <summary>
        /// Clears the text from the Display Text Box and makes other properties to default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            log.Debug("Clearing the calculator contents to default started");

            txtBoxDisplayData.Text = "0";
            isNewNumber = true;
            operation = string.Empty;
            previousNumber = 0;

            log.Debug("Clearing the calculator contents to default completed");
        }

        #endregion  --- Button Click Events ---


        #region --- Private API's ---

        /// <summary>
        /// Calculation logic for 4 arithemtic operations
        /// </summary>
        private void Calculate()
        {
            log.Debug("Calculation started.");

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = calculator.Add(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    log.Debug("Calculation performed for addition.");
                    break;

                case "-":
                    result = calculator.Subtract(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    log.Debug("Calculation performed for subtraction.");
                    break;

                case "Å~":
                    result = calculator.Multiply(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    log.Debug("Calculation performed for Multiplication.");
                    break;

                case "/":
                    result = calculator.Divide(previousNumber, double.Parse(txtBoxDisplayData.Text));
                    log.Debug("Calculation performed for Divison.");
                    break;
            }

            txtBoxDisplayData.Text = result.ToString();
            isNewNumber = true;

            log.Debug("Calculation completed successfully.");
        }

        #endregion  --- Private API's ---
    }
}
