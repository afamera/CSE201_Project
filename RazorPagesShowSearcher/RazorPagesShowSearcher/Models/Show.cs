using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesShowSearcher.Models
{
    public class Show
    {
      

        public int ID { get; set; }
        public string ShowName { get; set; }
        public string ShowDescription { get; set; }
        public double ShowRate { get; set; }
        public int NumOfSeasons { get; set; }
        public int YearShowBegan { get; set; }
        public string Genra { get; set; }
        public string ShowTitle { get; set; }
        public string OriginalNetwork { get; set; }

 

        
    }
}
