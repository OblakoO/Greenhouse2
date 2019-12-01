using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Ninject;

namespace Presentation
{
    public class CreateNewPlanPresentor : IPresentor
    {
        private readonly IKernel _kernel;
        private ICreateNewPlanView _view;


        //сервис

        public CreateNewPlanPresentor(IKernel kernel, ICreateNewPlanView view /*ещё один сервис*/)
        {
            _kernel = kernel;
            _view = view;
            _view.SavePlan += SavePlan;
            _view.ChoiseTheCulture += ChoiseTheCulture;
            _view.StartCycle += StartCycle;
            _view.BackToMainWindow += BackToMainWindow;
            //ещё хрень

        }

        private void SavePlan()
        {

        }

        private void ChoiseTheCulture()
        {

        }

        private void StartCycle()
        {
            //var presenter = _kernel.Get<ShowGreenhousePresentor>();
            //presenter.Run();
            _kernel.Get<ShowGreenhousePresentor>().Run();
            _view.Close();
        }

        private void BackToMainWindow()
        {
           // var presenter = _kernel.Get<MainWindowPresentor>();
            //presenter.Run();

            _kernel.Get<MainWindowPresentor>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }


        //методы
    }

}
