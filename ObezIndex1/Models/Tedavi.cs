using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    public class Tedavi
    {
        [Key]
        public int tmt_ID { get; set; }

        public String tmt_info { get; set; }

    }
}
