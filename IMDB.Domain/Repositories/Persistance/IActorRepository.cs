using IMDB.Domain.Core;
using IMDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Domain.Repositories.Persistance
{
    public interface IActorRepository : IBaseCompleteRepository<Actor>
    {
    }
}
