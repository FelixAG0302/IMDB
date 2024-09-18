using IMDB.Application.Models.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaDirector
{
    public class MediaDirectorModel
    {
        public int Id { get; set; }
        public int MediaContentId {  get; set; }
        public int DirectorId { get; set; }
        public MediaDirectorModel MediaContent { get; set; }
        public DirectorModel Director { get; set; }
    }
}
