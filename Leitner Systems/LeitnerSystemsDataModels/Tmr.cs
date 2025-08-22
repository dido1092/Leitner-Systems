using System.ComponentModel.DataAnnotations;

namespace Leitner_Systems.LeitnerSystemsDataModels
{
    public class Tmr
    {
        public Tmr()
        {
            
        }

        [Key]
        public int Id { get; set; }

        public string BoxOne { get; set; }

        public string BoxTwo { get; set; }

        public string BoxThree { get; set; }

        public string BoxFour { get; set; }

        public string BoxFive { get; set; }

        public string MHD { get; set; } // Minutes, Hours, Days

        public DateTime InsertDate { get; set; } = DateTime.Now;

    }
}
