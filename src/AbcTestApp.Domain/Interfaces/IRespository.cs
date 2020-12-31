using AbcTestApp.Domain.Kernel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbcTestApp.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
