using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MovieAward.Models
{
    public class GetOMDBResults
    {

        public List<MovieModel> Search { get; set; } = new List<MovieModel>();
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public int totalResults { get; set; }
        public bool Response { get; set; }
        }
}
