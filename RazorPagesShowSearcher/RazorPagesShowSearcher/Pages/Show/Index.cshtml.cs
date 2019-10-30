using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesShowSearcher.Data;
using RazorPagesShowSearcher.Models;

namespace RazorPagesShowSearcher.Pages.Shows
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext _context;

        public IndexModel(RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext context)
        {
            _context = context;
        }

        public IList<Show> Show { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genras { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ShowGenra { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from s in _context.Show
                                            orderby s.Genra
                                            select s.Genra;

            // Show = await _context.Show.ToListAsync();
            var shows = from s in _context.Show
                        select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                shows = shows.Where(s => s.ShowName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ShowGenra))
            {
                shows = shows.Where(x => x.Genra == ShowGenra);
            }

            Genras = new SelectList(await genreQuery.Distinct().ToListAsync());
            Show = await shows.ToListAsync();
        }
    }
}
