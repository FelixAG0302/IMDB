using IMDB.Application.Models.Cast;
using IMDB.Application.Models.MediaActor;
using IMDB.Application.Models.MediaDirector;
using IMDB.Application.Models.MediaGender;
using IMDB.Application.Models.MediaProducer;
using IMDB.Application.Models.MediaType;
using IMDB.Application.Models.Rating;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaContent
{
    public class MediaContentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Duration {  get; set; }
        public int Awards { get; set; }
        public string Synopsis { get; set; }
        public int MediaGenderId { get; set; }
        public int TypeId { get; set; }
        public int MediaActorId { get; set; }
        public int MediaDirectorId { get; set; }
        public int CastId { get; set; }
        public int MediaProducerId { get; set; }
        public int RatingId { get; set; }
        public List<MediaGenderModel> MediaGender { get; set; }
        public MediaTypeModel Type { get; set; }
        public List<MediaActorModel> MediaActor { get; set; }
        public List<MediaDirectorModel> MediaDirector { get; set; }
        public CastModel Cast { get; set; }
        public List<MediaProducerModel> MediaProducer { get; set; }
        public RatingModel Rating { get; set; }
    }
}
