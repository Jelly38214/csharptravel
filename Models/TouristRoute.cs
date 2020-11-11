using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faketravel.API.Models
{
    public class TouristRoute
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal OriginPrice { get; set; }
        // NOTE: ? means nullable
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string Features { get; set; }
        public string Fees { get; set; }
        public string Notes { get; set; }

        // NOTE: Setup Relationship, 1 vs N
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
    }
}