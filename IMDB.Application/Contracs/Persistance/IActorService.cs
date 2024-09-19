using IMDB.Application.Core;
using IMDB.Application.Models.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Contracs.Persistance
{
    public interface IActorService : IBaseCompleteService<ActorModel, SaveActorModel>
    {
    }
}
