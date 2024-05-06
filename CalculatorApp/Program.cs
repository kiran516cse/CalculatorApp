using CalculatorApp.BAL;
using CalculatorApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //  Setup dependency injection container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICalculator, CalculatorBAL>() // Use CalculatorBAL for basic Calculator
                                                            //  .AddSingleton<ICalculator, ScientificCalculatorBAL>() // Use ScientificCalculatorBAL for scientific Calculator
                .BuildServiceProvider();

            //  Create an instance of the Calulator UI and pass the calculator implementation
            using (Calculator basicCalculatorUI = new(serviceProvider.GetService<ICalculator>()))
            {
                Application.Run(basicCalculatorUI);
            }
        }
    }
}