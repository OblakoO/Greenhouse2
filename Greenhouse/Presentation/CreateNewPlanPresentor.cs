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
        private ICreateNewPlanService _service;

        public CreateNewPlanPresentor(IKernel kernel, ICreateNewPlanView view, ICreateNewPlanService service)
        {
            _kernel = kernel;
            _view = view;
            _view.StartCycle += StartCycle;
            _view.BackToMainWindow += BackToMainWindow;

            _service = service;
            //для сервиса нужно действие

        }

        private void StartCycle()
        {
            _service.CreatePlan(_view.PlanName);
            //var presenter = _kernel.Get<ShowGreenhousePresentor>();
            //presenter.Run();
            //if (_view.Cultur==null || _view.NamePlan==null )
            //{
            //    _service.CreateNewPlan(_view.Cultur, _view.NamePlan);
            //}
            //else
            //{
            //    _view.ShowError("Invalid 'Initiative' value");
            //}
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
