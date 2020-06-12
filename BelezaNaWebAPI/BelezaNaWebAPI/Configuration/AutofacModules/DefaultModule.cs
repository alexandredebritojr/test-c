﻿using Autofac;

namespace BelezaNaWebAPI.Modules
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Repo.ProductsRepo>().As<Repo.IProductsRepo>().SingleInstance();
        }
    }
}
