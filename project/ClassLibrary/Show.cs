using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Show
    {
        private String showName;
        private String showDescription;
        private double showRate;
        private int numOfSeasons;
        private int yearShowBegan;
        private String genra;
        private String showTitle;
        private String originalNetwork;

        public Show(string showName, string showDescription, double showRate, int numOfSeasons, 
            int yearShowBegan, string genra, string showTitle, string originalNetwork)
        {
            this.showName = showName;
            this.showDescription = showDescription;
            this.showRate = showRate;
            this.numOfSeasons = numOfSeasons;
            this.yearShowBegan = yearShowBegan;
            this.genra = genra;
            this.showTitle = showTitle;
            this.originalNetwork = originalNetwork;
        }

        // getters and setters
        public string ShowName { get => showName; set => showName = value; }
        public string ShowDescription { get => showDescription; set => showDescription = value; }
        public double ShowRate { get => showRate; set => showRate = value; }
        public int NumOfSeasons { get => numOfSeasons; set => numOfSeasons = value; }
        public int YearShowBegan { get => yearShowBegan; set => yearShowBegan = value; }
        public string Genra { get => genra; set => genra = value; }
        public string ShowTitle { get => showTitle; set => showTitle = value; }
        public string OriginalNetwork { get => originalNetwork; set => originalNetwork = value; }

        public override bool Equals(object obj)
        {
            return obj is Show show &&
                   showName == show.showName &&
                   showDescription == show.showDescription &&
                   showRate == show.showRate &&
                   numOfSeasons == show.numOfSeasons &&
                   yearShowBegan == show.yearShowBegan &&
                   genra == show.genra &&
                   showTitle == show.showTitle &&
                   originalNetwork == show.originalNetwork;
        }

        public override int GetHashCode()
        {
            var hashCode = -1780644785;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(showName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(showDescription);
            hashCode = hashCode * -1521134295 + showRate.GetHashCode();
            hashCode = hashCode * -1521134295 + numOfSeasons.GetHashCode();
            hashCode = hashCode * -1521134295 + yearShowBegan.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(genra);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(showTitle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(originalNetwork);
            return hashCode;
        }
    }
}
