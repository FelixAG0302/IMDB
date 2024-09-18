using IMDB.Application.Models.MediaContent;
using IMDB.Application.Models.Producer;
using IMDB.Application.Models.Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.Cast
{
    public class CastModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool State {  get; set; }
        public RolModel Rol { get; set; }
        public ProducerModel Producer {  get; set; }
        public MediaContentModel MediaContent { get; set; }
    }
}
