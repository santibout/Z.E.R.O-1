using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Domain
{
    public class PeopleUpdateRequest : PeopleAddRequest
    {
        public int Id { get; set; }
    }
}
