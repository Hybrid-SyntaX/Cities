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

        }
    }
}
