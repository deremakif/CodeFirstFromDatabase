using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFromDatabase
{
    public class Personnel
    {
        public string TcNo { get; set; }
        public string AdSoyad { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
