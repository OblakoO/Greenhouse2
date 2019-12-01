using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation
{
    public interface IMainWindowView : IView
    {
        event Action CreateNewPlan;
        event Action ShowGreenhouse;
        event Action StartCycle;
        event Action ChoisePlan;

        void ShowError(string message);
        //дописать воиды
    }
}
