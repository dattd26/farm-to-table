using System.Collections.Generic;
using FarmToTable.Domain.Common;

namespace FarmToTable.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int FarmId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Unit { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
        public string? ImageUrls { get; set; }
        public bool IsOrganic { get; set; }

        // Navigation properties
        public virtual Farm Farm { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<HarvestBatch> HarvestBatches { get; set; } = new List<HarvestBatch>();
    }
}
