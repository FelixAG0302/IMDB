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
    internal class ActorRepository : BaseCompleteRepository<Actor>, IActorRepository
    {
        private readonly ApplicationContext _context;
        public ActorRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
        public override Task<Actor> GetByIdAsync(int Id)
        {
            return base.GetByIdAsync(Id);
        }

        public override Task<bool> DeleteAsync(int Id)
        {
            return base.DeleteAsync(Id);
        }

        public override Task<List<Actor>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<bool> UpdateAsync (Actor actor)
        {
            try
            {
                if (!await ExitsAsync(c => c.Id == actor.Id)) return false;
                Actor actorToBeUpdated = await _context.Actor.FindAsync(actor);

                actorToBeUpdated.Name = actor.Name;
                actorToBeUpdated.Description = actor.Description;
                actorToBeUpdated.Awards = actor.Awards;

                return await base.UpdateAsync(actorToBeUpdated);
            }
            catch
            {
                return false;
            }
        }
    }
}
