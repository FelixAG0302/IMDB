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
    public class MediaTypeRepository : BaseCompleteRepository<MediaType>, IMediaTypeRepository
    {
        private readonly ApplicationContext _context;
        public MediaTypeRepository(ApplicationContext context) : base (context)
        {
            _context = context;
        }

        public override Task<List<MediaType>> GetAllAsync()
        {
            return base.GetAllAsync();
        }
        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }
        public override Task<MediaType> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override async Task<bool> UpdateAsync(MediaType entity)
        {
            try
            {
                if (!await base.ExitsAsync(m => m.Id == GetQuerableEntity().Id)) return false;
                MediaType mediaTypeToBeUpdated = await _context.MediaType.FindAsync(entity);
                mediaTypeToBeUpdated.Name = entity.Name;
                mediaTypeToBeUpdated.Description = entity.Description;
                return await base.UpdateAsync(mediaTypeToBeUpdated);
            }
            catch
            {
                return false;
            }
            

        }
    }
}
