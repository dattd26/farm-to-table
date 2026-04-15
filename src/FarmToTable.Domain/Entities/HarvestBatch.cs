using System;
using System.Collections.Generic;
using FarmToTable.Domain.Common;
using FarmToTable.Domain.Enums;

namespace FarmToTable.Domain.Entities
{
    public class HarvestBatch : BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime HarvestDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal OriginalQuantity { get; set; }
        public decimal CurrentQuantity { get; set; }
        public BatchStatus BatchStatus { get; set; } = BatchStatus.Selling;
        public decimal? PriceAtHarvest { get; set; }

        // Navigation properties
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
