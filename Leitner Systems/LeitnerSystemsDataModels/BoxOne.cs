using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitner_Systems.LeitnerSystemsDataModels
{
    public class BoxOne
    {
        public BoxOne()
        {

        }

        [Key]
        public int Id { get; set; }

        public string EnWord { get; set; }

        public string BgWord { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime PerformanceTime { get; set; }
    }
}
