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
        private IShowGreenhouseView _view;
        

        public ShowGreenhousePresentor(IKernel kernel, IShowGreenhouseView view)
        {
            _kernel = kernel;
       
            _view = view;
            _view.AddDevice += AddDevice;
            _view.DeleteDevice += DeleteDevice;
            _view.ChoiseDevice += ChoiceDevice;
            _view.BackToMainWindow += BackToMainWindow;
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

        public void Run()
        {
            _view.Show();
        }
    }
}
