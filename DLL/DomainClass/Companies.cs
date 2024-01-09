using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DomainClass
{
    public class Companies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PersonCompany> LstPerson { get; set; }
    }
}
