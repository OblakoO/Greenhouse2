using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Model;

namespace Presentation
{
    public class MainWindowPresentor : IPresentor
    {
        private readonly IKernel _kernel;
        private IMainWindowView _view;
        //тут ещё один интерфейс другого сервиса

        public MainWindowPresentor(IKernel kernel, IMainWindowView view /*тут сервис*/)
        {
            _kernel = kernel;
            _view = view;
            _view.CreateNewPlan += CreateNewPlan;    //?
            //тут куча ещё



        }

        //дальше идёт private void
        private void CreateNewPlan()
        {
            //var presenter = _kernel.Get<CreateNewPlanPresentor>();
            //presenter.Run();
            _kernel.Get<CreateNewPlanPresentor>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }

    }
}
