using IMDB.Domain.Entities;
using IMDB.Domain.Repositories.Persistance;
using IMDB.Infraestructure.Context;
using IMDB.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Infraestructure.Repositories
{
    public class DirectorRepository : BaseCompleteRepository<Director> , IDirectorRepository
    {
        private readonly ApplicationContext _context;
        public DirectorRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override Task<List<Director>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<Director> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }

        public override async Task<bool> UpdateAsync(Director entity)
        {
            try
            {
                if (!await base.ExitsAsync(d => d.Id == entity.Id)) return false;
                Director directorToBeUpdated = await _context.Director.FindAsync(entity.Id);
                directorToBeUpdated.Name = entity.Name;
                directorToBeUpdated.Description = entity.Description;
                directorToBeUpdated.Awards = entity.Awards;
                return await base.UpdateAsync(directorToBeUpdated);
            }
            catch
            {
                return false;
            }
        }
    }
}
