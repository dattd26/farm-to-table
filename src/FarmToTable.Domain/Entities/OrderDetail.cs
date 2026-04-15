using FarmToTable.Domain.Common;

namespace FarmToTable.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int BatchId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; } = null!;
        public virtual HarvestBatch HarvestBatch { get; set; } = null!;
    }
}
