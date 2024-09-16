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
    public class ProducerRepository : BaseCompleteRepository<Producer>, IProducerRepository
    {
        private readonly ApplicationContext _context;
        public ProducerRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override Task<List<Producer>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }

        public override Task<Producer> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override async Task<bool> UpdateAsync(Producer entity)
        {
            try
            {
                if (!await base.ExitsAsync(p => p.Id == entity.Id)) return false;
                Producer producerToBeUpdated = await _context.Producer.FindAsync(entity.Id);
                producerToBeUpdated.Name = entity.Name;
                producerToBeUpdated.Description = entity.Description;
                producerToBeUpdated.Awards = entity.Awards;
                return await base.UpdateAsync(producerToBeUpdated);
            }
            catch
            {
                return false;
            }
        }
    }
}
