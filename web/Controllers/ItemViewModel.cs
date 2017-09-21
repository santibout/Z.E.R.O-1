using System.Collections.Generic;
using models.Domain;

namespace Z.E.R.O_1.web.Controllers
{
    internal class ItemResponse<T>
    {
        public T Item { get; set; }
        //public List<People> Items { get; internal set; }
        //public List<T> Items { get; set; }
    }
}