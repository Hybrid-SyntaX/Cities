using Cities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Persistence.Interfaces
{
    public interface ICityRepository
    {
        /// <summary>
        /// Retrieve all cities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<City>> GetCitiesAsync();
    }
}
