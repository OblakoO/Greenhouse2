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
        private readonly IRepository<Plan> _repository;
        public CreateNewPlanService(IRepository<Plan> repository)
        {
            _repository = repository;
        }

        public void CreatePlan(string name)
        {
            Plan plan = new Plan { Name = name };
            _repository.Add(plan);
        }
    }
}

