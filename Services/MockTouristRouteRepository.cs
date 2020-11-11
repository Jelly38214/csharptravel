using System;
using System.Collections.Generic;
using System.Linq;

using Faketravel.API.Models;

namespace Faketravel.API.Services
{
    public class MockTouristRouteRepository : ITouristRouteRepository
    {

        private List<TouristRoute> _routes;

        public MockTouristRouteRepository()
        {
            if (_routes == null)
            {
                InitializeTouristRoutes();
            }
        }

        private void InitializeTouristRoutes()
        {
            _routes = new List<TouristRoute> {
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "黄山",
                    Description = "黄山有趣",
                    OriginPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees="<p>交通费自理</p>",
                    Notes="<p>小心危险</p>"

                },
                new TouristRoute {
                    Id = Guid.NewGuid(),
                    Title = "华山",
                    Description = "华山有趣",
                    OriginPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees="<p>交通费自理</p>",
                    Notes="<p>小心危险</p>"
                }
            };
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _routes.FirstOrDefault(n => n.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }

    }
}