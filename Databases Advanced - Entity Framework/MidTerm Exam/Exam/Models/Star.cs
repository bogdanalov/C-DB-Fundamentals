﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Star
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int? SolarSystemId { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }

        
    }
}
