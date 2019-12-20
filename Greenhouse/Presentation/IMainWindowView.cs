using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation
{
    public interface IMainWindowView : IView
    {
        event Action CreateNewPlan;

        //дописать воиды
    }
}
