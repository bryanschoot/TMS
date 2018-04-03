using System;
using System.Collections.Generic;

namespace TMS.Repository.Interface
{
    public interface IRepository<T>
    {
        void Create(T entity);
        T Read(int id);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}