using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IOrderService:IGenericService<Order>
    {
        public int TTotalOrderCount();
        public int TActiveOrderCount();
        public decimal TLastOrderPrice();
        public decimal TTodayTotalPrice();
    }
}
