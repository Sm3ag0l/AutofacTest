using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test.Application;
using Test.Commands;
using Test.Interfaces;

namespace Test.Container
{
    public static class Container
    {
        public static IContainer Config()
        {
            var container = new ContainerBuilder();

            // neccessary for start of application
            container.RegisterType<ApplicationStart>().As<IApplicationStart>();

            //container.RegisterType<Commands.Command>().As<ICommand>().WithParameter(new TypedParameter(typeof(Action), "sectionName"));

            container.RegisterType<Messager>().As<IMessager>().WithParameter(new TypedParameter(typeof(string), "Schreib mir den Text"));

            container.RegisterType<Command>().As<ICommand>().WithParameter(new TypedParameter(typeof(Action), new Action(() => Console.WriteLine("ActionText"))));


            //
            container.Register<Func<string, ICommand>>(delegate (IComponentContext context)
             {
                 IComponentContext cc = context.Resolve<IComponentContext>();

                 return cc.ResolveNamed<ICommand>;
             });



            return container.Build();
        }
    }
}
