using System.Collections.Generic;
using System.Text;

namespace Book.Model.ViewModels
{
    public class CategoryVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
