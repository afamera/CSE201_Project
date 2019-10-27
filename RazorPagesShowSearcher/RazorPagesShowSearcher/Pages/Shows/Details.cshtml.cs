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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext _context;

        public DetailsModel(RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext context)
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
