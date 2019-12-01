using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Find(int id);
    }
}
