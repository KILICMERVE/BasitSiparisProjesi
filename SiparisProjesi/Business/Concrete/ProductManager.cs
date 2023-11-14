using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IResult Add(Product product)
        {

            _productRepository.Add(product);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Product product)
        {
            _productRepository.Delete(product);
            return new SuccessResult(Messages.Deleted);
        }

        public List<Product> GetAll()
        {
            return new List<Product>(_productRepository.GetList());
        }

        public IResult Update(Product product)
        {
            _productRepository.Update(product);
            return new SuccessResult(Messages.Updated);
        }
    }
}
