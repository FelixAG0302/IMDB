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
    public class RatingRepository : BaseCompleteRepository<Rating>, IRatingRepository
    {
        private readonly ApplicationContext _context;
        public RatingRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override Task<List<Rating>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }

        public override Task<Rating> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override async Task<bool> UpdateAsync(Rating entity)
        {
            try
            {
                if (!await base.ExitsAsync(r => r.Id == entity.Id)) return false;
                Rating ratingToBeUpdated = await _context.Rating.FindAsync(entity);
                ratingToBeUpdated.Value = entity.Value;
                ratingToBeUpdated.Description = entity.Description;
                return await base.UpdateAsync(ratingToBeUpdated);

            }
            catch
            {
                return false;
            }
        }
    }
}
