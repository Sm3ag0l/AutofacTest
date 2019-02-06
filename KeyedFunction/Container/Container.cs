using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KeyedFunction.Application;
using KeyedFunction.Interfaces;
using KeyedFunction.DataService;
using KeyedFunction.Controller;

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
            container.RegisterType<HomeController>().As<IHomeController>();

            container.RegisterType<NormalDataService>().As<IDataService>().Keyed<IDataService>(RoleName.Normal);
            container.RegisterType<PremiumDataService>().As<IDataService>().Keyed<IDataService>(RoleName.Premium);

            container.Register<Func<RoleName, IDataService>>(c =>
            {
                var componentContext = c.Resolve<IComponentContext>();
                return (roleName) =>
                {
                    var dataService = componentContext.ResolveKeyed<IDataService>(roleName);
                    return dataService;
                };
            });

            return container.Build();
        }
    }
}
