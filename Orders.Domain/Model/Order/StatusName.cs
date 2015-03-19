namespace Orders.Domain.Model.Order
{
    public enum StatusName
    {
        New,
        Paid,
        InStock,
        Shipment,
        Received,
        Finished,
        Canceled
    }
}