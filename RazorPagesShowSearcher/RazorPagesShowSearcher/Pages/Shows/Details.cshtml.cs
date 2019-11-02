using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesShowSearcher.Models;
using ShowSearcher.Data;

namespace RazorPagesShowSearcher.Pages.Shows
{
    public class DetailsModel : PageModel
    {
        private readonly ShowSearcher.Data.ShowSearcherContext _context;

        public DetailsModel(ShowSearcher.Data.ShowSearcherContext context)
        {
            _context = context;
        }

        public Show Show { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Show = await _context.Show.FirstOrDefaultAsync(m => m.ID == id);

            if (Show == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
