﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public interface IRepository<T> where T : class
    {
        int Add(T obj);
        void Update(T obj);
        void Remove(int id);
        void Save();
        T Find(int id);
        IEnumerable<T> GetAll();



        //IEnumerable<T> GetAll();
        //T Find(int id);
    }
}
