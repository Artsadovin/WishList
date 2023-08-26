using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PageOfWishes<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public List<T> Wishes { get; set; }

        public PageOfWishes()
        {
            Wishes = new List<T>();
        }

        public PageOfWishes(IEnumerable<T> records)
        {
            Wishes = new List<T>(records);
        }
    }
}
