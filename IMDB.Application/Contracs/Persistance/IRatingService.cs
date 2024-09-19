using IMDB.Application.Core;
using IMDB.Application.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Contracs.Persistance
{
    public interface IRatingService : IBaseCompleteService<RatingModel, SaveRatingModel>   
    {
    }
}
