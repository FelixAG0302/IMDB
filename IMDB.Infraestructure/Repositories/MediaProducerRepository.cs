using IMDB.Domain.Core;
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
    public class MediaProducerRepository : BaseRepository<MediaProducer>, IMediaProducerRepository
    {
        private readonly ApplicationContext _context;
        public MediaProducerRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
