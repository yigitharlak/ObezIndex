using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    [Keyless]
    public class HastaHas
    {
        [ForeignKey("Hasta")]
        public int pat_ID { get; set; }

        [ForeignKey("Hastalik")]
        public int ill_ID { get; set; }
    }
}
