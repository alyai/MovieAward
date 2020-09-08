using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAward.Data;
using MovieAward.Models;

namespace MovieAward.OMDB
{
    public class OMDBSaved
    {
        private readonly MoviesDbContext _context;

        public OMDBSaved(MoviesDbContext context)
        {
            _context = context;
        }

        public async Task<List<MovieModel>> Get()
        {
            return await _context.Saved.ToListAsync();
        }

        public async Task<MovieModel> Add(MovieModel movie)
        {
            _context.Saved.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<MovieModel> Delete(string id)
        {
            var movie = await _context.Saved.FindAsync(id);
            _context.Saved.Remove(movie);
            await _context.SaveChangesAsync();
            return movie;
        }
    }
}
