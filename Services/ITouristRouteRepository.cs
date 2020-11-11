using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faketravel.API.Models;

namespace Faketravel.API.Services
{
    public interface ITouristRouteRepository
    {
        // NOTE: Database Array Type: IEnumerable 
        IEnumerable<TouristRoute> GetTouristRoutes();
        TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}