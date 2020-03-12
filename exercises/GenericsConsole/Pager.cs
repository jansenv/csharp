using System.Collections.Generic;
using System.Linq;

namespace GenericsConsole
{
    public class Pager<Taco>
    {
        public int ItemsPerPage { get; set; }
        public int PageNumber { get; set; }
        public List<Taco> AllItems { get; set; }
        public List<Taco> GetPage()
        {
            return AllItems
            .Skip(ItemsPerPage * PageNumber)
            .Take(ItemsPerPage)
            .ToList();
        }
    }
}