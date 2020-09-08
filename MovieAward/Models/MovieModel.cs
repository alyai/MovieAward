using System;
using System.ComponentModel.DataAnnotations;

namespace MovieAward.Models
{
    public class MovieModel
    {
        [Key]
        public string ImdbId { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public string Released { get; set; }

        public string Director { get; set; }

        public string Actors { get; set; }

        public string Plot { get; set; }

        public string Poster { get; set; }

        public string Runtime { get; set; }

        public bool Saved { get; set; } = false;
    }
}
