using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesShowSearcher.Models
{
    public class Show
    {

        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ShowName { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string ShowDescription { get; set; }

        [Range(0, 10)]
        public double ShowRate { get; set; }

        [Range(1, 100)]
        [Required]
        public int NumOfSeasons { get; set; }

        [Range(1900, 2020)]
        [Required]
        public int YearShowBegan { get; set; }

        [Required]
        [StringLength(30)]
        public string Genre { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OriginalNetwork { get; set; }

        [Range(0, 0)]
        public string numOfLike { get; set; }

        [Range(0, 0)]
        public string numOfDislike { get; set; }
    }
}
