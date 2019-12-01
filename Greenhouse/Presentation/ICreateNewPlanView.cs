using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation
{
    public interface ICreateNewPlanView : IView
    {
        event Action ChoiseTheCulture;
        event Action SavePlan;
        event Action StartCycle;
        event Action BackToMainWindow;
    }
}
