using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EF;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace Business.Dependency.autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<BaseRepository<Product, BaseProjectContext>>().As<IBaseRepository<Product>>().SingleInstance();
            
        }
    }
}
