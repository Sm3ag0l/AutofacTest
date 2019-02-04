using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application;
using Test.Interfaces;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Test.Container.Container.Config();

            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplicationStart>();

                app.Run();
            }
        }
    }
}
