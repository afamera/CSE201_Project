using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Show> Show { get;set; }

        public async Task OnGetAsync()
        {
            Show = await _context.Show.ToListAsync();
        }
    }
}
