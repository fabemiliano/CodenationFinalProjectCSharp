using System;
using System.Collections.Generic;
using System.Linq;
using CodenationFinalProject.Models;

namespace CodenationFinalProject.Repository
{
    public class BaseRepository<T> : IBaseInterface<T> where T : class, IEntity
    {

        public Context context;

        public BaseRepository(Context context)
        {
            this.context = context;
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public T CreateNew(T newEntry)
        {
            context.Set<T>().Add(newEntry);
            context.SaveChanges();
            return newEntry;
        }

        public T Update(T newEntry)
        {
            context.Set<T>().Update(newEntry);
            context.SaveChanges();
            return newEntry;
        }

        public T Delete(int id)
        {
            T entry = GetById(id);
            context.Set<T>().Remove(entry);
            context.SaveChanges();
            return entry;
        }

    }
}
