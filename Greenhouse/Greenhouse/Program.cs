using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using DAL;
using Model;
using Model.Entity;
using Model.Service;
using Presentation;



namespace Greenhouse
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            
            kernel.Bind<IMainWindowView>().To<MainWindowView>();
            kernel.Bind<ICreateNewPlanView>().To<Form3>();
            kernel.Bind<IShowGreenhouseView>().To<ShowGreenhouseView>();
            kernel.Bind<IGreenhouseService>().To<GreenhouseService>();
            kernel.Bind<ICreateNewPlanService>().To<CreateNewPlanService>();
            //kernel.Bind<IRepository<Character>>().To<CharacterRepository>();
            //kernel.Bind<IRepository<InitiativeEntry>>().To<InitiativeEntryRepository>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<MainWindowPresentor>().Run();
            Application.Run(kernel.Get<ApplicationContext>());

            
        }
    }
}
