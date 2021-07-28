using OngProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}
