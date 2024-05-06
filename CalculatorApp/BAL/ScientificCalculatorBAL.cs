using CalculatorApp.Interfaces;

namespace CalculatorApp.BAL
{
    /// <summary>
    /// This class is used to have the Scientific Calculator functionalities.
    /// Currently the API's are exposed but the functionalities needs to be implemented as and when it is required.
    /// </summary>
    public class ScientificCalculatorBAL : ICalculator, IScientificCalculator
    {
        #region --- Constructor --- 

        /// <summary>
        /// Constructor
        /// </summary>
        public ScientificCalculatorBAL()
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
        /// <exception cref="NotImplementedException"></exception>
        public double Add(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Cosine(double angleValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Divide functionality for Basic Calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public double Divide(double x, double y)
        {
            throw new NotImplementedException();
        }

        public long Factorial(int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Multiply functionality for Basic Calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public double Multiply(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double NthRoot(double x, double n)
        {
            throw new NotImplementedException();
        }

        public double Power(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Sine(double angleValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Square Root functionality is used in Scientific Calculator
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double SquareRoot(double number)
        {
            //  Need to return the value and modify the logic to update on to the DisplayTextBox accordingly
            //  Also, Need to add a Square Root button on the Calculator UI along with the Click functionality.
            return Math.Sqrt(number);
        }

        /// <summary>
        /// Subtract functionality for Basic Calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public double Subtract(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Tangent(double angleValue)
        {
            throw new NotImplementedException();
        }

        #endregion --- API's ---
    }
}