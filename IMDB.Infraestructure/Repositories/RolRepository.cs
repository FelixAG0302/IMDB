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
    public class RolRepository : BaseCompleteRepository<Rol> , IRolRepository
    {
        private readonly ApplicationContext _context;
        public RolRepository (ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override Task<List<Rol>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }

        public override Task<Rol> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override async Task<bool> UpdateAsync(Rol entity)
        {
            try
            {
                if (!await base.ExitsAsync(r => r.Id == entity.Id)) return false;
                Rol rolToBeUpdated = await _context.Rol.FindAsync(entity.Id);
                rolToBeUpdated.Name = entity.Name;
                rolToBeUpdated.Description = entity.Description;
                rolToBeUpdated.Position = entity.Position;
                return await base.UpdateAsync(rolToBeUpdated);
            }
            catch
            {
                return false;
            }
        }
    }
}
