using System;
using System.Collections.Generic;

namespace CodenationFinalProject.Repository
{
    public interface IBaseInterface<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public T CreateNew(T newEntry);
        public T Update(T newEntry);
        public T Delete(int id);
    }
}
