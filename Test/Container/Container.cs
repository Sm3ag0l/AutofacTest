using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application;
using Test.Interfaces;

namespace Test.Container
{
    public static class Container
    {
        public static IContainer Config()
        {
            var container = new ContainerBuilder();

            container.RegisterType<IApplicationStart>().As<ApplicationStart>();


            return container.Build();
        }
    }
}
