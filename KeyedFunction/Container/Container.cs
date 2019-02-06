using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KeyedFunction.Application;
using KeyedFunction.Interfaces;

namespace KeyedFunction.Container
{
    public static class Container
    {
        public static IContainer Config()
        {
            var container = new ContainerBuilder();

            //neccessary for programm start
            container.RegisterType<ApplicationStart>().As<IApplicationStart>();

            //Stuff comes here





            return container.Build();
        }
    }
}
