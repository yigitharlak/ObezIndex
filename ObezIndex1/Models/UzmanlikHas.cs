using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    [Keyless]
    public class UzmanlikHas
    {
        [ForeignKey("Doktor")]
        public int doc_ID { get; set; }

        [ForeignKey("Uzmanlik")]
        public int pro_ID { get; set; }


    }
}
