using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    public class Tani
    {
        [Key]
        public int dgn_ID { get; set; }
    
        public String dgn_info { get; set; }

    }
}
