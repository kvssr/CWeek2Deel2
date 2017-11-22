using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Week2Deel1
{
    public class Huis
    {
        [Key]
        public int HuisId { get; set; }
        public int AantalKamers { get; set; }
        [Required]
        public int Bouwjaar { get; set; }
        [StringLength(50)]
        public string Plaats { get; set; }   
    }
}
