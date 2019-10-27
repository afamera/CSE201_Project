using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesShowSearcher.Models;

namespace RazorPagesShowSearcher.Data
{
    public class RazorPagesShowSearcherContext : DbContext
    {
        public RazorPagesShowSearcherContext (DbContextOptions<RazorPagesShowSearcherContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesShowSearcher.Models.Show> Show { get; set; }
    }
}
