using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using MovieAward.Data;
using MovieAward.Models;
using MovieAward.OMDB;

namespace MovieAward.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly OMDBResults _service;

        public ResultsModel(OMDBResults service)
        {
            _service = service;
        }

        public IList<MovieModel> Movies { get; set; } = new List<MovieModel>();

        public async Task OnGetAsync(string title)
        {
            Movies = await _service.Search(title);
        }
    }
}
