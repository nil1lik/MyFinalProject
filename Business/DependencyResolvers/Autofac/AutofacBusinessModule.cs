using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule:Module
	{
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //Biri senden ProductManager isterse ona IProductService ver.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            //Biri senden EfProductDal isterse ona IProductDal ver.
            //Sürekli newlemeye ihtiyacım olmuyor. Otomatik burada newleniyor.
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

