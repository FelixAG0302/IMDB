using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Domain.Entities
{
    public class Rating 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "decimal(4,3)")]
        public decimal Value { get; set; }
        public string Description { get; set; }
        [ForeignKey("MediaId")]
        public MediaContent MediaId {  get; set; }
        [ForeignKey("ActorId")]
        public Actor ActorId { get; set; }
    }
}
