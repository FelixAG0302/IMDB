using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaGender
{
    public class SaveMediaGenderModel
    {
        public int Id { get; set; }
        public int GenderId { get; set; }
        public int MediaContentId { get; set; }
    }
}
