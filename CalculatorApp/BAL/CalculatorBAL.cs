using CalculatorApp.Interfaces;

namespace CalculatorApp.BAL
{
    public class CalculatorBAL : ICalculator
    {
        #region --- Constructor ---

        /// <summary>
        /// Constructor
        /// </summary>
        public CalculatorBAL()
        {
        }

        #endregion  --- Constructor ---

        #region --- API's ---

        /// <summary>
        /// Add functionality for Basic Calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Divide functionality for Basic Calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Multiply functionality for Basic Calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Multiply(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Subtract functionality for Basic Calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Subtract(double x, double y)
        {
            return x - y;
        }

        #endregion  --- API's ---
    }
}