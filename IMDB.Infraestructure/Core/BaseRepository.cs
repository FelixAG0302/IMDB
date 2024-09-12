using IMDB.Domain.Core;
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
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _context;
        private DbSet<TEntity> _entities;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }
        Task<bool> IBaseRepository<TEntity>.DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseRepository<TEntity>.ExitsAsync(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseRepository<TEntity>.SaveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
