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
        {
            this.citiesDbContext = citiesDbContext;

            createSampleCities();
        }

        private void createSampleCities()
        {
            if (citiesDbContext.Cities?.Count() == 0)
            {
                citiesDbContext.AddRange(new City[]{
                    new City { Name = "Tehran" },
                    new City { Name = "Isfahan" },
                    new City { Name = "Shiraz" },
                    new City { Name = "Tabriz" },
                    new City { Name = "Ahwaz" },
                });
                citiesDbContext.SaveChanges();
            }
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
            => await citiesDbContext.Cities.ToListAsync();

    }
}
