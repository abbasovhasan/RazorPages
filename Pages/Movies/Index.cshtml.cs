using GoreyRazorNedi.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GoreyRazorNedi.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly GoreyRazorNedi.Data.RazorUreydiContext _context;

        public IndexModel(GoreyRazorNedi.Data.RazorUreydiContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
