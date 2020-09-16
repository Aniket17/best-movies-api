using best_movies_api.Models;
using System;
using System.Collections.Generic;

namespace best_movies_api
{
    public class Movie:BaseModel
    {
        public string ImdbId { get; set; }
        public double ImdbRating { get; set; }
        public string Language { get; set; }
        public ListingType ListingType { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public List<MovieSoundEffect> SoundEffects { get; set; }
        public List<MovieStills> Stills { get; set; }
        public string Title { get; set; }
    }

    public enum ListingType
    {
        Now_Showing,
        Released,
        Comming_Soon
    }
}
