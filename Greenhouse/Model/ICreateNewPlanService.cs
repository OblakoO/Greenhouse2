using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public interface ICreateNewPlanService
    {
        //event Action PlanUpdated;
        void CreatePlan(string name);
    }
}
