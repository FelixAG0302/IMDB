using IMDB.Application.Core;
using IMDB.Application.Models.Gender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Contracs.Persistance
{
    public interface IGenderService : IBaseCompleteService<GenderModel, SaveGenderModel>
    {
    }
}
