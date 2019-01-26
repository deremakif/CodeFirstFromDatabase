using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFromDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballContext db = new FootballContext();
            var teams = db.Teams.Where(x=>x.Id>=4).ToList();
            db.Teams.RemoveRange(teams);
            db.SaveChanges();

        }
    }
}
