using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesShowSearcher.Models
{
    public class Show
    {
        public Show()
        {
            ID = 0;
            ShowName = string.Empty;
            ShowDescription = string.Empty;
            ShowRate = 0;
            NumOfSeasons = 0;
            YearShowBegan = 0;
            Genre = string.Empty;
            OriginalNetwork = string.Empty;
            NumOfLike = 0;
            NumOfDislike = 0;
            WikiLink = string.Empty;
        }

        public Show(int id, string showName, string showDescription, double showRate, int NumOfSeason, int yearShowBegan,
                    string genre, string originalNetwork, int numOfLike, int numOfDislike, string wikiLink)
        {
            ID = id;
            ShowName = showName;
            ShowDescription = showDescription;
            ShowRate = showRate;
            NumOfSeasons = NumOfSeason;
            YearShowBegan = yearShowBegan;
            Genre = genre;
            OriginalNetwork = originalNetwork;
            NumOfLike = numOfLike;
            NumOfDislike = numOfDislike;
            WikiLink = wikiLink;
        }

        public int ID { get; set; }

        [Required]
        public string ShowName { get; set; }

        public string ShowDescription { get; set; }

        [Range(0, 10)]
        public double ShowRate { get; set; }

        public int NumOfSeasons { get; set; }

        [Range(1900, 2020)]
        [Required]
        public int YearShowBegan { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string OriginalNetwork { get; set; }

        public int NumOfLike { get; set; }

        public int NumOfDislike { get; set; }

        public String WikiLink { get; set; }
    }
}
