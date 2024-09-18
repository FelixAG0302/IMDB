using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaActor
{
    public class SaveMediaActorModel
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int MediaContentId { get; set; }
    }
}
