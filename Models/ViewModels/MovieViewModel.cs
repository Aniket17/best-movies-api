using best_movies_api.Models;
using System;
using System.Collections.Generic;

namespace best_movies_api
{
    public class MovieViewModel:BaseViewModel
    {
        public string ImdbId { get; set; }
        public double ImdbRating { get; set; }
        public string Language { get; set; }
        public ListingType ListingType { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public List<string> SoundEffects { get; set; }
        public List<string> Stills { get; set; }
        public string Title { get; set; }
    }
}
