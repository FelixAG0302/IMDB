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
    public class CastRepository : BaseCompleteRepository<Cast>, ICastRepository
    {
        private readonly ApplicationContext _context;
        public CastRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override Task<Cast> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override Task<List<Cast>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<bool> UpdateAsync(Cast entity)
        {
            try
            {
                if (!await base.ExitsAsync(c => c.Id == entity.Id)) return false;
                Cast castToBeUpdated = await _context.Cast.FindAsync(entity.Id);
                castToBeUpdated.Name = entity.Name;
                castToBeUpdated.Description = entity.Description;
                castToBeUpdated.State = entity.State;
                return await base.UpdateAsync(castToBeUpdated);

            }
            catch
            {
                return false;
            }
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }
    }
}
