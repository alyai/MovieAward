using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MovieAward.Data;
using MovieAward.Models;
using Newtonsoft.Json;

namespace MovieAward.Pages
{
    public class SavedModel : PageModel
    {
        private readonly MoviesDbContext _context;

        public SavedModel(MoviesDbContext context)
        {
            _context = context;
        }

        public IList<MovieModel> Movies { get; set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Saved.ToListAsync();
        }

        public ActionResult OnGetMovies()
        {
            return new JsonResult(_context.Saved.ToList());
        }
    }
}
