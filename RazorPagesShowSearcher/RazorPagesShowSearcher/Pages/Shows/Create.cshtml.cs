using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesShowSearcher.Data;
using RazorPagesShowSearcher.Models;

namespace RazorPagesShowSearcher.Pages.Shows
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext _context;

        public CreateModel(RazorPagesShowSearcher.Data.RazorPagesShowSearcherContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Show Show { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Show.Add(Show);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
