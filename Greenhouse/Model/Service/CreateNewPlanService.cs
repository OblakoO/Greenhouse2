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
        private readonly IRepository<Plan> _plan_repository;
        private readonly JsonSerializer _serializer;
        //private IRepository<InitiativeEntry> _initiative_repository;
        public CreateNewPlanService(IRepository<Plan> plan_repository /*IRepository<InitiativeEntry> initiative_repository*/)
        {
            _plan_repository = plan_repository;
            //_initiative_repository = initiative_repository;
            _serializer = new JsonSerializer();
        }


        public IEnumerable<string> GetAllPlan()
        {
            return _plan_repository.GetAll().Select(c => c.Name);
        }

        public void SavePlan(StreamWriter writer)
        {
            _serializer.Serialize(writer, _plan_repository.GetAll());
        }

        public void StartCycle(string name)
        {
            var plan = _plan_repository.GetAll().FirstOrDefault(c => c.Name == name);
            if (plan == null)
            {
                _plan_repository.Add(new Plan { Name = name });
                _plan_repository.Save();
                PlanUpdated?.Invoke();
            }
        }

        public event Action PlanUpdated;

        public void CreateNewPlan(string cultur, string namePlan/*, int Stage, int Hours, int Temperature,
                                  int Humidity, int Light, int Acidity*/)
        {
            Plan plan = new Plan();
            plan.Name = cultur;
            _plan_repository.Add(plan);
            //var entry = _initiative_repository.GetAll().FirstOrDefault(c => c.Name == name);
            //if (entry == null)
            //{
            //    _initiative_repository.Add(new InitiativeEntry { Name = name, Initiative = initiative });
            //}
            //else
            //{
            //    entry.Initiative = initiative;
            //    _initiative_repository.Update(entry);
            //}
            //_initiative_repository.Save();
            //InitiativeUpdated?.Invoke();
        }
    }
}
