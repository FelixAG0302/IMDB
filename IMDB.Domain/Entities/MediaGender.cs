﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Domain.Entities
{
    public class MediaGender
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
        [ForeignKey("MediaId")]
        public MediaContent MediaId { get; set; }
    }
}
