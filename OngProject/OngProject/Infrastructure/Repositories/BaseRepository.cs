﻿using Microsoft.EntityFrameworkCore;
using OngProject.Core.Interfaces;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Infrastructure.Repositories.IRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            _entities.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
