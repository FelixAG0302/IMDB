using IMDB.Application.Models.Actor;
using IMDB.Application.Models.MediaContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.Rating
{
    public class RatingModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public ActorModel Actor { get; set; }
        public MediaContentModel MediaContent {  get; set; }
    }
}
