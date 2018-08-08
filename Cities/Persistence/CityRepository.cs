using Cities.Models;
using Cities.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Persistence
{
    public class CityRepository : ICityRepository
    {
        private readonly CitiesDbContext citiesDbContext;

        public CityRepository(CitiesDbContext citiesDbContext)
            => this.citiesDbContext = citiesDbContext;

        public async Task<IEnumerable<City>> GetCitiesAsync()
            => await citiesDbContext.Cities.ToListAsync();

    }
}
