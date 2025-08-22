using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitner_Systems.LeitnerSystemsDataModels
{
    public class WordMovement
    {
        public WordMovement()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string EnWord { get; set; }

        [Required]
        public string BgWord { get; set; }

        [Required]
        public string FromBox { get; set; }

        [Required]
        public string ToBox { get; set; }

        [Required]
        public string DisplayLanguage { get; set; }

        [Required]
        public bool Hint { get; set; }

        [Required]
        public DateTime InsertDate { get; set; }
    }
}
