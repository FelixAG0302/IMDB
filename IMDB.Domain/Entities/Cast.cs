using IMDB.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Domain.Entities
{
    public class Cast : BaseEntity
    {
        [ForeignKey("Rol")]
        public Rol RolId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer ProducerId { get; set; }
        [ForeignKey("MediaId")]
        public MediaContent MediaId { get; set; }
        [ForeignKey("ActorId")]
        public Actor ActorId { get; set; }
        public bool State { get; set; }
    }
}
