using System.Collections.Generic;
using Model;
using Model.Entity;

namespace DAL
{
    public class InitiativeEntryRepository //: IRepository<InitiativeEntry>
    {
        //private static List<InitiativeEntry> _data = new List<InitiativeEntry>();
        //private static int _end_index = 0;
        //public int Add(InitiativeEntry obj)
        //{
        //    obj.Id = _end_index;
        //    _end_index += 1;
        //    _data.Add(obj);
        //    return obj.Id;
        //}

        //public void Update(InitiativeEntry obj)
        //{
        //    var initiativeEntry = _data.Find(ie => ie.Id == obj.Id);
        //    if (initiativeEntry != null)
        //        initiativeEntry.Name = obj.Name;
        //}

        //public void Remove(int id)
        //{
        //    _data.RemoveAll(ie => ie.Id == id);
        //}

        //public void Save()
        //{
        //}

        //public InitiativeEntry Find(int id)
        //{
        //    return _data.Find(ie => ie.Id == id);
        //}

        //public IEnumerable<InitiativeEntry> GetAll()
        //{
        //    return _data.ToArray();  // create copy to avoid update via reference
        //}
    }
}
