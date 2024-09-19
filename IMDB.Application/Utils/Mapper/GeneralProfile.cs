using AutoMapper;
using IMDB.Application.Models.Actor;
using IMDB.Application.Models.Cast;
using IMDB.Application.Models.Director;
using IMDB.Application.Models.Gender;
using IMDB.Application.Models.MediaActor;
using IMDB.Application.Models.MediaType;
using IMDB.Application.Models.Producer;
using IMDB.Application.Models.Rating;
using IMDB.Application.Models.Rol;
using IMDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Utils.Mapper
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {

            #region
            CreateMap<Actor, SaveActorModel>()
                .ReverseMap();

            CreateMap<Actor, ActorModel>() 
                .ReverseMap();
            #endregion

            #region
            CreateMap<Cast, SaveCastModel>()
                .ReverseMap();

            CreateMap<Director, DirectorModel>()
                .ReverseMap();
            #endregion

            #region
            CreateMap<Director, SaveDirectorModel>()
                .ReverseMap();

            CreateMap<Director, DirectorModel>()
                .ReverseMap();
            #endregion

            #region
            CreateMap<Gender, SaveGenderModel>()
                .ReverseMap();

            CreateMap<Gender, GenderModel>()
                .ReverseMap();
            #endregion


            #region
            CreateMap<MediaActor, SaveMediaActorModel>()
                .ReverseMap();

            CreateMap<MediaActor, MediaActorModel>()
                .ReverseMap();
            #endregion

            #region
            CreateMap<MediaType, SaveMediaTypeModel>()
                .ReverseMap();
            CreateMap<MediaType, SaveMediaTypeModel>()
                .ReverseMap();
            #endregion

            #region
            CreateMap<Producer, SaveProducerModel>()
                .ReverseMap();
            CreateMap<Producer, SaveProducerModel>()
                .ReverseMap();
            #endregion

            #region
            CreateMap<Rating, SaveRatingModel>()
                .ReverseMap();
            CreateMap<Rating, RatingModel>()
                .ReverseMap();
            #endregion

            #region
            CreateMap<Rol, SaveRolModel>()
                .ReverseMap();
            CreateMap<Rol, RolModel>()
                .ReverseMap(); 
            #endregion
        }
    }
}
