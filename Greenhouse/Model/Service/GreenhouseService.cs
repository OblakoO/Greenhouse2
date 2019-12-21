using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Service
{
    public class GreenhouseService: IGreenhouseService
    {
        private readonly IRepository<Plan> _planRepository;
        public GreenhouseService(IRepository<Plan> planRepository)
        {
            _planRepository = planRepository;
        }

        public string GetPlanName()
        {
            var plan = _planRepository.GetAll().FirstOrDefault();
            if (plan != null)
            {
                return plan.Name;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
