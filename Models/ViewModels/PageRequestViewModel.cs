using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace best_movies_api.Models.ViewModels
{
    public class PageRequestViewModel<T>
    {
        public T Filter { get; set; }
        public int PageNumber { get; set; }
        [Required]
        public int PageSize { get; set; }
        public string SortField { get; set; }
        public string SortOrder { get; set; }
    }
    public class MovieFilter : BaseFilter
    {
        public string Location { get; set; }
    }
    public class BaseFilter
    {
        public string Search { get; set; }
    }
}
