using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Ninject;

namespace Presentation
{
    public class ShowGreenhousePresentor : IPresentor
    {
        private readonly IKernel _kernel;
        private readonly IShowGreenhouseView _view;
        private readonly IGreenhouseService _service;


        public ShowGreenhousePresentor(IKernel kernel, IShowGreenhouseView view, IGreenhouseService service)
        {
            _kernel = kernel;
       
            _view = view;
            _view.AddDevice += AddDevice;
            _view.DeleteDevice += DeleteDevice;
            _view.ChoiseDevice += ChoiceDevice;
            _view.BackToMainWindow += BackToMainWindow;

            _service = service;
        }
        private void AddDevice()
        {

        }

        private void DeleteDevice()
        {

        }

        private void ChoiseDevice()
        {

        }

        private void BackToMainWindow()
        {
            _kernel.Get<MainWindowPresentor>().Run();
            _view.Close();
        }

        private void ChoiceDevice()
        {

        }

        private void UpdateView()
        {
            _view.PlanName = _service.GetPlanName();
        }

        public void Run()
        {
            UpdateView();
            _view.Show();
        }
    }
}
