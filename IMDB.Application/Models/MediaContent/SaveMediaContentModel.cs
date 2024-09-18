using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaContent
{
    public class SaveMediaContentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Duration { get; set; }
        public int Awards { get; set; }
        public string Synopsis { get; set; }
        public int MediaGenderId { get; set; }
        public int TypeId { get; set; }
        public int MediaActorId { get; set; }
        public int MediaDirectorId { get; set; }
        public int CastId { get; set; }
        public int MediaProducerId { get; set; }
        public int RatingId { get; set; }
    }
}
