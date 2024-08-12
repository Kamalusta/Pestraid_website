using Business.Abstract;
using Business.Helpers.Results.Abstract;
using Business.Validation.FluentValidation;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager(IBaseRepository<Product> baseRepository) : IProductService
    {
        private readonly IBaseRepository<Product> _baseRepository = baseRepository;

        public IResult Add(Product product)
        {
            var validator = new ProductValidator();
            ValidationTool<Product>.Validation(validator, product);

            _baseRepository.Add(product);
            return new SuccessResult("Product Added");
        }

        public IResult Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
