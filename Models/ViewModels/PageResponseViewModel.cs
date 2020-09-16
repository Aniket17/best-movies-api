using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace best_movies_api.Models.ViewModels
{
    public class PageResponseViewModel<T>
    {
        public PageResponseViewModel()
        {
        }
        public PageResponseViewModel(IEnumerable<T> _data, int totalCount)
        {
            this.Items = _data;
            TotalCount = totalCount;
        }

        //for ng-mat table
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
        public string ErrorMessage { get; set; }
    }
}
