using System.Collections.Generic;
using Model;
using Model.Entity;

namespace DAL
{
    public class PlanRepository : IRepository<Plan>
    {
        private static List<Plan> _data = new List<Plan>();
        private static int _end_index = 0;
        public int Add(Plan obj)
        {
            obj.Id = _end_index;
            _end_index += 1;
            _data.Add(obj);
            return obj.Id;
        }

        public void Update(Plan obj)
        {
            var character = _data.Find(c => c.Id == obj.Id);
            if (character != null)
                character.Name = obj.Name;
        }

        public void Remove(int id)
        {
            _data.RemoveAll(c => c.Id == id);
        }

        public void Save()
        {
        }

        public Plan Find(int id)
        {
            return _data.Find(c => c.Id == id);
        }

        public IEnumerable<Plan> GetAll()
        {
            return _data;  // create copy to avoid update via reference
        }
    }
}
