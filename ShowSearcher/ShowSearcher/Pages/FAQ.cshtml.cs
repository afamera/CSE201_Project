using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ShowSearcher.Pages
{
    public class FAQModel : PageModel
    {
        private readonly ILogger<FAQModel> _logger;

        public FAQModel(ILogger<FAQModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
