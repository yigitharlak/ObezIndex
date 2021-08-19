using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    public class Uzmanlik
    {
        [Key]
        public int pro_ID { get; set; }

        public String pro_info { get; set; }

    }
}