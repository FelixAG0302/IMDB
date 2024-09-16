using IMDB.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Domain.Entities
{
    public class MediaContent  : BaseEntity
    {
        public DateOnly ReleaseDate { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal Duration { get; set; }
        public int Awards { get; set; }
        public string Synopsis { get; set; }
        [ForeignKey("MediaGenderId")]
        public MediaGender MediaGenderId { get; set; }
        [ForeignKey("TypeId")]
        public MediaType TypeId { get; set; }
        [ForeignKey("ActorId")]
        public MediaActor MediaActorId { get; set; }
        [ForeignKey("MediaDirectorId")]
        public MediaDirector MediaDirectorId { get; set; }
        [ForeignKey("CastId")]
        public Cast CastId { get; set; }
        [ForeignKey("MediaProducerId")]
        public MediaProducer MediaProducerId { get; set; }
        [ForeignKey("RatingId")]
        public Rating RatingId { get; set; }

    }
}
