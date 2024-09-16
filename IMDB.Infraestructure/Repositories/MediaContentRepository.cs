using IMDB.Domain.Core;
using IMDB.Domain.Entities;
using IMDB.Domain.Repositories.Persistance;
using IMDB.Infraestructure.Context;
using IMDB.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Infraestructure.Repositories
{
    public class MediaContentRepository : BaseCompleteRepository<MediaContent>, IMediaContentRepository
    {
        private readonly ApplicationContext _context;
        public MediaContentRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }

        public override async Task<List<MediaContent>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        public override Task<MediaContent> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }
        public override async Task<bool> UpdateAsync(MediaContent entity)
        {
            try
            {
                if (!await base.ExitsAsync(i => i.Id == entity.Id)) return false;

                MediaContent mediaContentToBeUpdated = await _context.MediaContent.FindAsync(entity.Id);
                mediaContentToBeUpdated.Name = entity.Name;
                mediaContentToBeUpdated.Description = entity.Description;
                mediaContentToBeUpdated.Awards = entity.Awards;
                mediaContentToBeUpdated.Duration = entity.Duration;
                mediaContentToBeUpdated.Synopsis = entity.Synopsis;
                return await base.UpdateAsync(mediaContentToBeUpdated);
            }
            catch
            {
                return false;
            }
        }

    }
}
