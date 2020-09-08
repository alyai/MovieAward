using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAward.Data;
using MovieAward.Models;
using Newtonsoft.Json;

namespace MovieAward.OMDB
{
    public class OMDBResults
    {
        private readonly MoviesDbContext _context;

        public OMDBResults(MoviesDbContext context)
        {
            _context = context;
        }

        public async Task<MovieModel> Get(string id)
        {
       
            string json = await MoviesDbContext.OMDB.GetStringAsync($"http://www.omdbapi.com/?apikey=2fc051e&i={id}&plot=full");
            MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(json);

            List<MovieModel> savedMovies = await _context.Saved.ToListAsync();
            if (savedMovies.Any(m => m.ImdbId == movie.ImdbId))
            {
                movie.Saved = true;
            }

            return movie;
        }

        public async Task<List<MovieModel>> Search(string title)
        {

            if (title == null)
            {
                title = "";
            }
       
            string json = await MoviesDbContext.OMDB.GetStringAsync($"http://www.omdbapi.com/?apikey=2fc051e&s={title}");
            GetOMDBResults omdb = JsonConvert.DeserializeObject<GetOMDBResults>(json);

            List<MovieModel> savedMovies = await _context.Saved.ToListAsync();

            foreach (MovieModel movie in omdb.Search)
            {
                if (savedMovies.Any(m => m.ImdbId == movie.ImdbId))
                {
                    movie.Saved = true;
                }
            }
            await _context.SaveChangesAsync();

            return omdb.Search;
        }
    }
}
