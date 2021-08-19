using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    public class Doktor
    {
        [Key]
        public int doc_ID { get; set; }

        public String doc_name { get; set; }

        public String doc_title{ get; set; }
        
        public String doc_profession { get; set; }

        public String doc_address { get; set; }

        public String doc_info { get; set; }

        public String doc_username { get; set; }

        public String doc_password { get; set; }
    }
}
