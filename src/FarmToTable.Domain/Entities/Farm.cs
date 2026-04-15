using System.Collections.Generic;
using FarmToTable.Domain.Common;

namespace FarmToTable.Domain.Entities
{
    public class Farm : BaseEntity
    {
        public string FarmName { get; set; } = string.Empty;
        public string? OwnerName { get; set; }
        public string Address { get; set; } = string.Empty;
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? Certification { get; set; }

        // Navigation properties
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
