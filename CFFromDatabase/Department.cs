using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFromDatabase
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personnel> Personnels { get; set; }
    }
}
