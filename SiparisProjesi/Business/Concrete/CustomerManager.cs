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
    public class CustomerManager : ICustomerService
    {
        ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IResult Add(Customer customer)
        {

            _customerRepository.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Customer customer)
        {
            _customerRepository.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>(_customerRepository.GetList());
        }

        public IResult Update(Customer customer)
        {
            _customerRepository.Update(customer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
