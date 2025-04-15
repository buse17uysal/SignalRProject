using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int TActiveOrderCount()
        {
            return _orderDal.ActiveOrderCount();
        }

        public decimal TLastOrderPrice()
        {
            return _orderDal.LastOrderPrice();
        }

        public decimal TTodayTotalPrice()
        {
            return _orderDal.TodayTotalPrice();
        }

        public int TTotalOrderCount()
        {
            return _orderDal.TotalOrderCount();
        }

        void IGenericService<Order>.TAdd(Order entity)
        {
            _orderDal.Add(entity);
        }

        void IGenericService<Order>.TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        Order IGenericService<Order>.TGetByID(int id)
        {
            return _orderDal.GetByID(id);
        }

        List<Order> IGenericService<Order>.TGetListAll()
        {
            return _orderDal.GetListAll();
        }

        void IGenericService<Order>.TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
