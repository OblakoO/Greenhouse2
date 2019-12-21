using System;
using System.Collections.Generic;
using Model;
using Model.Entity;

namespace DAL
{
    public class PlanRepository : IRepository<Plan>
    {
        List<Plan> _data = new List<Plan>();
        private int _end_index = 0;

        public int Add(Plan obj)
        {
            _data.Add(obj);
            _end_index++;
            return _end_index;
        }

        public Plan Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Plan> GetAll()
        {
            return _data;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Plan obj)
        {
            throw new NotImplementedException();
        }
    }
}
