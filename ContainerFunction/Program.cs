using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ContainerFunction.Application;
using ContainerFunction.Interfaces;

namespace ContainerFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Container.Container.Config();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplicationStart>();

                app.Run();
            }
        }
    }
}
