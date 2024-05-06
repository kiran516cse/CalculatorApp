namespace CalculatorApp.Interfaces
{
    public interface IScientificCalculator
    {
        #region  --- Scientific Operations of a Calculator ---

        //  Calcualte the Sqaure Root
        double SquareRoot(double number);

        //  Factorial operation
        long Factorial(int n);

        //  Power operation
        double Power(double x, double y);

        //  Nth ROOT Operation
        double NthRoot(double x, double n);

        // Trigonometric Functions
        double Sine(double angleValue);
        double Cosine(double angleValue);
        double Tangent(double angleValue);

        // Add other scientific operations as needed

        #endregion  --- Scientific Operations of a Calculator ---
    }
}
