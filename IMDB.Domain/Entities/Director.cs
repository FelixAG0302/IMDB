using IMDB.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Domain.Entities
{
    public class Director : BaseEntity
    {
        public int Awards {  get; set; }
    }
}
