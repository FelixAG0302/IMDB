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
    public class GenderRepository : BaseCompleteRepository<Gender>, IGenderRepository
    {
        private readonly ApplicationContext _context;
        public GenderRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override Task<List<Gender>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }

        public override Task<Gender> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override async Task<bool> UpdateAsync(Gender entity)
        {
            try
            {
                if (!await base.ExitsAsync(d => d.Id == entity.Id)) return false;
                Gender genderToBeUpdated = await _context.Gender.FindAsync(entity.Id);
                genderToBeUpdated.Name = entity.Name;
                genderToBeUpdated.Description = entity.Description;
                return await base.UpdateAsync(genderToBeUpdated);
            }
            catch
            {
                return false;
            }
        }
    }
}
