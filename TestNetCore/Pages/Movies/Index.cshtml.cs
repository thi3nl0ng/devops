using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestNetCore.Data;
using TestNetCore.Models;

namespace TestNetCore.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly TestNetCore.Data.TestNetCoreContext _context;

        public IndexModel(TestNetCore.Data.TestNetCoreContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
