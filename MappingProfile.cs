using AutoMapper;
using System.Linq;

namespace best_movies_api
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieViewModel>().AfterMap((dbMovie, viewModel) =>
            {
                viewModel.SoundEffects = dbMovie.SoundEffects?.Select(x => x.Name).ToList();
                viewModel.Stills = dbMovie.Stills?.Select(x => x.Url).ToList();
            });
        }
    }
}