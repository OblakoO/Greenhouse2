using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation
{
    public interface ICreateNewPlanView : IView
    {
        string Cultur { get; }
        string PlanName { get; set; }
       // int Stage { get;  }
        //int Hours { get; }
        //int Temperature { get;  }
        //int Humidity { get;  }
        //int Light { get; }
        //int Acidity { get; }

        event Action StartCycle;
        event Action BackToMainWindow;

        //тут есть ещё один воид с енумерэйблом
        //void ShowCharacters(IEnumerable<string> characters);
        void ShowError(string message);
    }
}
