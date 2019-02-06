using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyedFunction.Application;
using KeyedFunction.Interfaces;

namespace KeyedFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = KeyedFunction.Container.Container.Config();

            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplicationStart>();

                app.Run();
            }
        }
    }
}
