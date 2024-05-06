namespace CalculatorApp.Interfaces
{
    public interface ICalculator
    {
        #region --- Basic Operations of a Calculator ---

        //  To perform Add functionality
        double Add(double x, double y);

        //  To perform Divide functionality
        double Divide(double x, double y);

        //  To perform Multiply functionality
        double Multiply(double x, double y);

        //  To perform Subtract functionality
        double Subtract(double x, double y);

        #endregion  --- Basic Operations of a Calculator ---
    }
}
