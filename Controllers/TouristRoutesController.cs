using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Faketravel.API.Models;
using Faketravel.API.Services;

namespace Faketravel.API.Controllers {
    [Route("api/[controller]")]
    public class TouristRoutesController: Controller {
        private ITouristRouteRepository _touristRouteRepository;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            _touristRouteRepository = touristRouteRepository;
        }

        public IActionResult GetTouristRoutes() {
            var routes = _touristRouteRepository.GetTouristRoutes();
            return Ok(routes);
        } 
    }
}