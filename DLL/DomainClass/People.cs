using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DomainClass
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public List<PersonCompany> LstPerson { get; set; }
    }
}
