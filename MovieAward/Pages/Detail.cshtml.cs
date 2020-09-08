using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieAward.OMDB;
using MovieAward.Models;


namespace MovieAward.Pages
{
    public class DetailModel : PageModel
    {
        private readonly OMDBResults _service;

        public DetailModel(OMDBResults service)
        {
            _service = service;
        }

        public MovieModel Movie { get; set; } = new MovieModel();

        public async Task OnGetAsync(string id)
        {
            Movie = await _service.Get(id);
        }
    }
}
