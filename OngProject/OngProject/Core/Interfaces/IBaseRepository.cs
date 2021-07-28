using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Models;

namespace OngProject.Core.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        bool SaveChanges();
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(int id);
        void Update(int id);
        void Delete(int id);
    }
}
