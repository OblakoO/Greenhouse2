using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public interface ICreateNewPlanService
    {
        event Action PlanUpdated;

        IEnumerable<string> GetAllPlan();
        void CreateNewPlan(string cultur, string namePlan/*, int Stage, int Hours, int Temperature,
                           int Humidity, int Light, int Acidity*/);
    }
}
