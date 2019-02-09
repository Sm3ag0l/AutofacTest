using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ContainerFunction.Application;
using ContainerFunction.Interfaces;
using Test.Container;

namespace ContainerFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Container.Container.Config();

            // scope is saved in a static class because in this programm we resolve directly from scope
            // when we resolve from container we get probles with memory leaks
            using (ContainerScope.Scope = container.BeginLifetimeScope())
            {
                var app = ContainerScope.Scope.Resolve<IApplicationStart>();

                app.Run();
            }
        }
    }
}
