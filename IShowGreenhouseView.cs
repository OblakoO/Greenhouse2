using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation
{
    public interface IShowGreenhouseView : IView
    {
        event Action AddDevice;
        event Action DeleteDevice;
        event Action ChoiseDevice;
        event Action BackToMainWindow;
    }
}
