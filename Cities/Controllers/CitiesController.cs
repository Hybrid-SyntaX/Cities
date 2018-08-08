using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cities.Models;
using Cities.Persistence;
using Cities.Persistence.Interfaces;

namespace Cities.Controllers
{

    public class CitiesController : Controller
    {
        private readonly ICityRepository cityRepository;

        public CitiesController(ICityRepository cityRepository)
            => this.cityRepository = cityRepository;

        /// <summary>
        /// Show a list of cities
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
            => View(await cityRepository.GetCitiesAsync());
    }
}
