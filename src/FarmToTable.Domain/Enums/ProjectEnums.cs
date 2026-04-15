namespace FarmToTable.Domain.Enums
{
    public enum BatchStatus
    {
        Selling = 1,
        OutOfStock = 2,
        Expired = 3
    }

    public enum OrderStatus
    {
        Pending = 1,
        Shipping = 2,
        Completed = 3,
        Cancelled = 4
    }

    public enum PaymentStatus
    {
        Unpaid = 0,
        Paid = 1
    }
}
