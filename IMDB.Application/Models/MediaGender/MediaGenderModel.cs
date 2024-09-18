using IMDB.Application.Models.Gender;
using IMDB.Application.Models.MediaContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaGender
{
    public class MediaGenderModel
    {
        public int Id { get; set; }
        public int GenderId { get; set; }
        public int MediaContentId {  get; set; }
        public GenderModel Gender { get; set; }
        public MediaContentModel MediaContent { get; set; }
    }
}
