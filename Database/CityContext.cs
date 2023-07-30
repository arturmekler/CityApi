using Database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class CityContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<Region> Regions { get; set; }
    }
}
