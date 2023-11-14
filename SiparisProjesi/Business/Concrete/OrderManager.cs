using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IResult Add(Order order)
        {

            _orderRepository.Add(order);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Order order)
        {
            _orderRepository.Delete(order);
            return new SuccessResult(Messages.Deleted);
        }

        public List<Order> GetAll()
        {
            return new List<Order>(_orderRepository.GetList());
        }

        public IResult Update(Order order)
        {
            _orderRepository.Update(order);
            return new SuccessResult(Messages.Updated);
        }
    }
}
