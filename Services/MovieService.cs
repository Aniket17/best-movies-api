using best_movies_api.Data;
using best_movies_api.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace best_movies_api.Services
{
    public class MovieService : BaseService, IMovieService
    {
        public MovieService(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Movie GetMovie(int id)
        {
            try
            {
               return _context.Movies.Where(x => x.Id == id).Include(x => x.Stills).Include(x => x.SoundEffects).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new Exception("Unable to get movie");
            }
        }

        public async Task<PageResponseViewModel<Movie>> GetMoviesAsync(PageRequestViewModel<MovieFilter> request)
        {
            string DEFAULT_SORT = "Title";
            var query = _context.Movies.Where(x=>!x.IsDeleted);
            if (request.Filter != null)
            {
                if (!string.IsNullOrEmpty(request.Filter.Search))
                {
                    //search with title
                    query = query.Where(x=>x.Title.Contains(request.Filter.Search));
                }
                if (!string.IsNullOrEmpty(request.Filter.Location))
                {
                    //search with location.. should give only exact matches?? no.
                    query = query.Where(x => x.Location.StartsWith(request.Filter.Location));
                }
                if (!string.IsNullOrEmpty(request.Filter.Language))
                {
                    //search with language.. should give only exact matches?? no.
                    query = query.Where(x => x.Language.StartsWith(request.Filter.Language));
                }
            }
            var result = await query.ToListAsync();
            var count = result.Count;
            result = SortQuery(result, request.SortField, request.SortOrder, DEFAULT_SORT).ToList();
            var page = result.Skip(request.PageSize * request.PageNumber).Take(request.PageSize).ToList();

            return new PageResponseViewModel<Movie>(page, count);
        }

        public List<string> GetMovieStills(int id)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMovieService {
        Task<PageResponseViewModel<Movie>> GetMoviesAsync(PageRequestViewModel<MovieFilter> request);
        Movie GetMovie(int id);
        List<string> GetMovieStills(int id);
    }
}
