using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.DTOs;
using OngProject.Core.Models;

namespace OngProject.Core.Interfaces.IServices
{
    public interface INewsService
    {
        public Task<IEnumerable<NewsModel>> GetAll();

        public Task<NewsDto> GetById(int id);

        public Task Insert(NewsModel newsModel);

        public Task Delete(int id);

        public Task Update(NewsModel newsModel);

        public bool NewsExists(int Id);
    }
}
