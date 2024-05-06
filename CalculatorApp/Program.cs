using CalculatorApp.BAL;
using CalculatorApp.Interfaces;
using log4net;
using log4net.Config;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp
{
    internal static class Program
    {
        #region --- Properties ---

        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        #endregion  --- Properties ---

        #region --- Main Execution Thread ---

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load log4net configuration
            XmlConfigurator.Configure(new FileInfo("log4net.config"));

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

        #endregion  --- Main Execution Thread ---
    }
}