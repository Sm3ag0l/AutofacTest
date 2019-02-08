using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ContainerFunction.Application;
using ContainerFunction.Commands;
using ContainerFunction.Interfaces;

namespace ContainerFunction.Container
{
    public static class Container
    {
        public static IContainer Config()
        {
            var container = new ContainerBuilder();

            // neccessary for start of application
            container.RegisterType<ApplicationStart>().As<IApplicationStart>();

            // test
            container.RegisterType<Command>().As<ICommand>();

            return container.Build();
        }
    }
}
