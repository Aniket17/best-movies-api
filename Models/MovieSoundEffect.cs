using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace best_movies_api.Models
{
    public class MovieSoundEffect:BaseModel
    {
        public string Name { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual MovieViewModel Movie { get; set; }
    }
}
