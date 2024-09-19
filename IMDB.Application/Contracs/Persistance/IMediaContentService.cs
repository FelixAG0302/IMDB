using IMDB.Application.Core;
using IMDB.Application.Models.MediaContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Contracs.Persistance
{
    public interface IMediaContentService : IBaseCompleteService<MediaContentModel, SaveMediaContentModel>
    {
    }
}
