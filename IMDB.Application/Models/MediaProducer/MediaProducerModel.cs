using IMDB.Application.Models.MediaContent;
using IMDB.Application.Models.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaProducer
{
    public class MediaProducerModel
    {
        public int Id { get; set; }
        public int Producerid { get; set; }
        public int MediaContentId {  get; set; }
        public ProducerModel Producer { get; set; }
        public MediaContentModel MediaContent { get; set; }
    }
}
