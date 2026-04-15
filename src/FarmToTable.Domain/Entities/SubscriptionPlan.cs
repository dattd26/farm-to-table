using System.Collections.Generic;
using FarmToTable.Domain.Common;

namespace FarmToTable.Domain.Entities
{
    public class SubscriptionPlan : BaseEntity
    {
        public string PlanName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int DurationDays { get; set; }

        // Navigation properties
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; } = new List<UserSubscription>();
    }
}
