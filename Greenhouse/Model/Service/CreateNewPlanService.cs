using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;
using Newtonsoft.Json;

namespace Model.Service
{
    public class CreateNewPlanService : ICreateNewPlanService
    {
        private string _planName;
        public string CreateNewPlan
        {
            get => _planName; set { if (value.Length > 0) _planName = value; }
        }
    }
}

