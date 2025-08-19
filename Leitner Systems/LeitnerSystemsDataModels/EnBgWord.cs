﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitner_Systems.LeitnerSystemsDataModels
{
    public class EnBgWord
    {
        public EnBgWord()
        {
            
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string EnWord { get; set; }

        [Required]
        public string BgWord { get; set; }
       
        [Required]
        public DateTime DateTime { get; set; }
    }
}
