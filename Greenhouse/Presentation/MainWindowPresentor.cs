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
            _view.ChoisePlan += ChoisePlan;     //?
            _view.CreateNewPlan += CreateNewPlan;    //?
            _view.ShowGreenhouse += ShowGeenhouse;    //?
           // _view.StartCycle += StartCycle();   //?
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

        private void ShowGeenhouse()
        {
            var presenter = _kernel.Get<ShowGreenhousePresentor>();
            presenter.Run();
            //_kernel.Get<ShowGreenhousePresentor>().Run();
            _view.Close();
        }

        private void StartCycle()
        {
            //if()
            var presenter = _kernel.Get<ShowGreenhousePresentor>();
            presenter.Run();
            _view.Close();


            // var presenter = _kernel.Get<ShowGreenhousePresentor>();
            //presenter.Run();
        }

        private void ChoisePlan()
        {

        }

        public void Run()
        {
            _view.Show();
        }

    }
}
