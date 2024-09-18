using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Application.Models.Cast
{
    public class SaveCastModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
    }
}
