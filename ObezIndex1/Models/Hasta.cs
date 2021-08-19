using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Models
{
    public class Hasta
    {
        [Key]
        public int pat_ID { get; set; }
        [Required]
        public String pat_name { get; set; }
        [Required]
        public String pat_username { get; set; }
        public String pat_password { get; set; }
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Boy uzunluğu 0'dan fazla olmalı")]
        public int pat_height { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Ağırlık 0'dan fazla olmalı")]
        public int pat_weight { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Yaş 0'dan fazla olmalı")]
        public int pat_age { get; set; }
        [Required]
        public String pat_gender { get; set; }
        public String pat_address { get; set; }
        public String pat_info { get; set; }

        public double CalculateBMI(int pat_weight, int pat_height)
        {
            //bmi = Math.pow(weight / height, 2)
            //return Math.round(bmi, 2)
            double bmi = Math.Pow(pat_weight / pat_height, 2);
            return Math.Round(bmi, 2);
        }

        public double CalculateIdealBW(int pat_height, String pat_gender)
        {
            if(pat_gender.Equals("erkek", StringComparison.CurrentCultureIgnoreCase))
            {
               return 50 + (0.91 * (pat_height - 152.4));
            }
            else if(pat_gender.Equals("kadın", StringComparison.CurrentCultureIgnoreCase))
            {
                return 45.5 + (0.91 * (pat_height - 152.4));
            }

            return 0;
        }

        public String CalculateIWInterval(int pat_height)
        {
            double low = (pat_height / 100 * pat_height / 100) * 18;
            double high = (pat_height / 100 * pat_height / 100) * 25;
            return low + "-" + high;
        }

        public double CalculateAjBW(int pat_weight, int pat_height, String pat_gender)
        {
            double IBW = CalculateIdealBW(pat_height, pat_gender);
            return IBW + 0.4 * (pat_weight - IBW);
        }
    }
}
