using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.MediaProducer
{
    public class SaveMediaProducer
    {
        public int Id { get; set; }
        public int Producerid { get; set; }
        public int MediaContentId { get; set; }
    }
}
