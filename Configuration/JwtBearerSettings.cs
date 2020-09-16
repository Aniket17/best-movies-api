using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace best_movies_api.Configuration
{
    public class JwtBearerConfig
    {
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Expires { get; set; }//minute value
    }
}
