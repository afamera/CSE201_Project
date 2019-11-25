using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesShowSearcher.Models;

namespace ShowSearcher.Data
{
    public class ShowSearcherContext : DbContext
    {
        public ShowSearcherContext (DbContextOptions<ShowSearcherContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesShowSearcher.Models.Show> Show { get; set; }
    }
}
