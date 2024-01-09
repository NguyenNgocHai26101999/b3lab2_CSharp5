using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DomainClass
{
    public class PersonCompany
    {
        public int Id { get; set; }

        public DateTime FromYear{ get; set; }
        public DateTime ToYear { get; set; }
        public string Position { get; set; }
        public int CompanyId { get; set; }
        public int PeopleId { get; set; }
        public Companies Companies { get; set; }
        public People People { get; set; }
    }
}
