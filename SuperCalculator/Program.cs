using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using SuperCalculator.Presenter;
using SuperCalculator.Service;

namespace SuperCalculator
{
    static class Program
    {
        static Ninject.StandardKernel kernel = new StandardKernel();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            kernel.Bind<CalculatorView>()
                .ToConstant(new CalculatorView())
                .InSingletonScope();
            kernel.Bind<CalculatorService>()
                .ToConstant(new CalculatorService())
                .InSingletonScope();
            kernel.Bind<CalculatorPresenter>()
                .ToConstant(new CalculatorPresenter(kernel.Get<CalculatorView>(), kernel.Get<CalculatorService>()))
                .InSingletonScope();
            Application.Run(kernel.Get<CalculatorView>());
        }
    }
}