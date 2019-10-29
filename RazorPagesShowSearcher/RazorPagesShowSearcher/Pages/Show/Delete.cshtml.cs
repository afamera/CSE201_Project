using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesShowSearcher.Data;
using RazorPagesShowSearcher.Models;

namespace RazorPagesShowSearcher
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext _context;

        public DeleteModel(RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Show = await _context.Show.FindAsync(id);

            if (Show != null)
            {
                _context.Show.Remove(Show);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
