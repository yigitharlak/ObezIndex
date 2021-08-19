using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    public class Hastalik
    {
        [Key]
        public int ill_ID { get; set; }
        public String ill_name { get; set; }
        public String ill_category { get; set; }
        public String ill_description { get; set; }
    
    }
}
