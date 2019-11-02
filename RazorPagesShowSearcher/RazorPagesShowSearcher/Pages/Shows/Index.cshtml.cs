using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesShowSearcher.Models;
using ShowSearcher.Data;

namespace RazorPagesShowSearcher.Pages.Shows
{
    public class IndexModel : PageModel
    {
        private readonly ShowSearcher.Data.ShowSearcherContext _context;

        public IndexModel(ShowSearcher.Data.ShowSearcherContext context)
        {
            _context = context;
        }

        public IList<Show> Shows { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShowGenre { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from s in _context.Show
                                            orderby s.Genre
                                            select s.Genre;

            // Show = await _context.Show.ToListAsync();
            var shows = from s in _context.Show
                        select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                shows = shows.Where(s => s.ShowName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ShowGenre))
            {
                shows = shows.Where(x => x.Genre == ShowGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Shows = await shows.ToListAsync();
        }
    }
}
