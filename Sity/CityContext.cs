using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sity
{
    class CityContext : DbContext
    {
        public CityContext() : base ("DbConnection")
        { }
        public DbSet<Cityes> City { get; set; }
        public DbSet<Numbers> Number { get; set; }
    }
}
