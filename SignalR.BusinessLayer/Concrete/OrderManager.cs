using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int TTotalOrderCount()
        {
            return _orderDal.TotalOrderCount();
        }

        void IGenericService<Order>.TAdd(Order entity)
        {
            throw new NotImplementedException();
        }

        void IGenericService<Order>.TDelete(Order entity)
        {
            throw new NotImplementedException();
        }

        Order IGenericService<Order>.TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Order> IGenericService<Order>.TGetListAll()
        {
            throw new NotImplementedException();
        }

        void IGenericService<Order>.TUpdate(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
