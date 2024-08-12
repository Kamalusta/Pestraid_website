// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EF;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

Product product = new Product()
{
    Name = "AgcaqanadDermani",
    Description = "Agcaqanadlari oldurur",
    IsDeleted = false,
    IsDiscount = false,
    DiscountRate = 0,
    Price = 3.5m,
    ImageUrl = "test"
};
ProductManager productManager = new ProductManager(new BaseRepository<Product, BaseProjectContext>());

productManager.Add(product);
