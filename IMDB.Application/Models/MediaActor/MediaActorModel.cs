using IMDB.Application.Models.Actor;
using IMDB.Application.Models.MediaContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaActor
{
    public class MediaActorModel
    {
        public int Id { get; set; }
        public int ActorId {get; set;}
        public int MediaContentId { get; set;}
        public ActorModel Actor { get; set; }
        public MediaContentModel MediaContent {  get; set; }
    }
}
