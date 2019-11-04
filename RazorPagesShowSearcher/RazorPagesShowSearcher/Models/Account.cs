using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesShowSearcher.Models
{
    public class Account
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        private List<string> Favorte { get; set; }

        public Boolean addToFavorites(string name)
        {
            return true;
        }

        public Boolean removeFromFavorites(string name)
        {
            return true;
        }

        public Boolean likeShow(string name)
        {
            return true;
        }

        public Boolean dislikeShow(string name)
        {
            return true;
        }

        public Boolean addShowInfo(string name)
        {
            return true;
        }

        public Boolean adeleteShowInfo(string name)
        {
            return true;
        }

        public Boolean editShowInfo(string name)
        {
            return true;
        }
    }
}
