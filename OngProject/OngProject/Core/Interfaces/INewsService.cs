using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.Models;

namespace OngProject.Core.Interfaces
{
    public interface INewsService
    {
        public Task<IEnumerable<NewsModel>> GetAll();
        public Task<NewsModel> GetById(int id);
        public Task Insert(NewsModel newsModel);
        public Task Delete(int id);
        public Task Update(NewsModel newsModel);
    }
}
