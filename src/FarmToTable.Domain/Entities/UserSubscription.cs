using System;
using FarmToTable.Domain.Common;

namespace FarmToTable.Domain.Entities
{
    public class UserSubscription : BaseEntity
    {
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime? EndDate { get; set; }

        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual SubscriptionPlan SubscriptionPlan { get; set; } = null!;
    }
}
