﻿using IMDB.Domain.Core;
using IMDB.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Infraestructure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly ApplicationContext _context;
        private DbSet<TEntity> _entities;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public virtual async Task<bool> DeleteAsync(int Id)
        {
           try
            {
                TEntity entityToBeDeleted = await _entities.FindAsync(Id);
                if (entityToBeDeleted == null) return false;

                _context.Remove(entityToBeDeleted);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual async Task<bool> ExitsAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.AnyAsync(filter);
        }

        public virtual async Task<bool> SaveAsync(TEntity entity)
        {
            try
            {
                await _entities.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class BaseCompleteRepository<TEntity> : BaseRepository<TEntity>, IBaseCompleteRepository<TEntity>
        where TEntity : class
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<TEntity> _entities;

        public BaseCompleteRepository(ApplicationContext context) : base(context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
            
        
        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _entities.FindAsync(Id);
        }

        public virtual async Task<IQueryable<TEntity>> GetQuerableEntity()
        {
            return await Task.FromResult(_entities);
        }

        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
                try
                {
                    _entities.Attach(entity);
                    _entities.Entry(entity).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
        }
    }
}
