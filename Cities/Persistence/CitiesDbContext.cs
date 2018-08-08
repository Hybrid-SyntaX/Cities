using Cities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Persistence
{
    /// <summary>
    /// Cities Website's DbContext
    /// </summary>
    public class CitiesDbContext : DbContext
    {
        /// <summary>
        /// Cities
        /// </summary>
        public DbSet<City> Cities { set; get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public CitiesDbContext(DbContextOptions options) : base(options)
        {
            if (Cities?.Count() == 0)
            {
                Cities.AddRange(new City[]{
                    new City { Name = "Tehran" },
                    new City { Name = "Isfahan" },
                    new City { Name = "Shiraz" },
                    new City { Name = "Tabriz" },
                });
                this.SaveChanges();
            }
        }
    }
}
