using GoreyRazorNedi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GoreyRazorNedi.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly GoreyRazorNedi.Data.RazorUreydiContext _context;

        public DetailsModel(GoreyRazorNedi.Data.RazorUreydiContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
