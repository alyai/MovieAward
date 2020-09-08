using System;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using MovieAward.Models;

namespace MovieAward.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions options) : base(options)
        {
        }

        public static readonly HttpClient OMDB = new HttpClient();

        public DbSet<MovieModel> Saved { get; set; }
    }
}
