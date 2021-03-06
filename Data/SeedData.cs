﻿using best_movies_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace best_movies_api.Data
{
    public class SeedData
    {
        public static void EnsureSeedData(string connectionString)
        {
            //data to seed
            var movieStills = new List<MovieStills>(){
                new MovieStills(){
                    Url = "https://m.media-amazon.com/images/M/MV5BNTYxOTYyMzE3NV5BMl5BanBnXkFtZTcwOTMxNDY3Mw@@._V1_UY99_CR24,0,99,99_AL_.jpg",
                },
                new MovieStills(){
                    Url = "https://m.media-amazon.com/images/M/MV5BNzAwOTk3MDg5MV5BMl5BanBnXkFtZTcwNjQxNDY3Mw@@._V1_UY99_CR29,0,99,99_AL_.jpg",
                },
                new MovieStills(){
                    Url = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL__QL50.jpg"
                }
            };
            List<Movie> movies = new List<Movie>() {
                new Movie(){
                    Title = "The Shawshank Redemption",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption2",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption3",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption4",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption5",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption6343",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption6232",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption634343",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption4346",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption632",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
                new Movie(){
                    Title = "The Shawshank Redemption12",
                    Language = "ENGLISH",
                    Location = "Delhi",
                    Stills = movieStills,
                    ImdbId = "tt0111161",
                    ListingType = ListingType.Now_Showing,
                    ImdbRating = 9.2,
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                    SoundEffects = new List<MovieSoundEffect>(){
                        new MovieSoundEffect(){
                            Name = "RX6",
                        },
                        new MovieSoundEffect(){
                            Name = "SDDS",
                        }
                    }
                },
            };

            List<IdentityUser> users = new List<IdentityUser>() {
                new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@lms.com",
                    EmailConfirmed = true,
                }
            };


            ServiceCollection services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(connectionString));

            services.AddIdentity<IdentityUser, IdentityRole>()
               .AddEntityFrameworkStores<ApplicationDbContext>();


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                using (IServiceScope scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    ApplicationDbContext context = scope.ServiceProvider.GetService<ApplicationDbContext>();
                    context.Database.Migrate();

                    UserManager<IdentityUser> userMgr = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

                    RoleManager<IdentityRole> roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                    if (!roleManager.RoleExistsAsync("SuperAdmin").Result)
                    {
                        IdentityResult res = roleManager.CreateAsync(new IdentityRole("SuperAdmin")).Result;
                    }
                   
                    foreach (IdentityUser user in users)
                    {
                        IdentityUser dbUser = userMgr.FindByNameAsync(user.UserName).Result;
                        if (dbUser == null)
                        {
                            IdentityResult result = userMgr.CreateAsync(user, "Admin@123").Result;
                            if (result.Succeeded)
                            {
                                IdentityResult res = userMgr.AddToRoleAsync(user, "SuperAdmin").Result;
                            }
                        }
                    }
                    foreach (Movie movie in movies)
                    {
                        //check if exists..
                        if (!context.Movies.Where(x => x.Title == movie.Title).Any())
                        {
                            context.Movies.Add(movie);
                        }
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
