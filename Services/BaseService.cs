using best_movies_api.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace best_movies_api.Services
{
    public class BaseService : IDisposable
    {
        protected readonly ApplicationDbContext _context;

        public BaseService(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        protected virtual PropertyDescriptor GetSortProp<T>(string sortField, string DEFAULT_SORT)
        {
            PropertyDescriptor prop = null;
            sortField = string.IsNullOrEmpty(sortField) ? DEFAULT_SORT : sortField;
            prop = TypeDescriptor.GetProperties(typeof(T)).Find(sortField, true);
            prop = prop ?? TypeDescriptor.GetProperties(typeof(T)).Find(DEFAULT_SORT, true);
            return prop;
        }
        protected virtual IEnumerable<T> SortQuery<T>(IEnumerable<T> query, string sortField, string sortOrder, string DEFAULT_SORT)
        {
            PropertyDescriptor prop = GetSortProp<T>(sortField, DEFAULT_SORT);
            if (sortOrder == "asc") //TODO move to contant
            {
                query = query.OrderBy(x => prop.GetValue(x));
            }
            else
            {
                query = query.OrderByDescending(x => prop.GetValue(x));
            }
            return query;
        }
    }
}
