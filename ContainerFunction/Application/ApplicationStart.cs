using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ContainerFunction.Commands;
using ContainerFunction.Interfaces;

namespace ContainerFunction.Application
{
    public class ApplicationStart : IApplicationStart
    {
        // the autofac container is built in a static class therefor there is no need to place it in the constructor of ApplicationStart class
        private IContainer _container;
        private readonly Func<Action, ICommand> _funcWithOneParameter;
        private readonly Func<Action, bool, ICommand> _funcWithTwoParameters;

        public ApplicationStart()
        {
            // the static autofac container 
            _container = Container.Container.Config();

            // with the container we create a constructor for the Command class 
            _funcWithOneParameter = _container.Resolve<Func<Action, ICommand>>();
            _funcWithTwoParameters = _container.Resolve<Func<Action, bool, ICommand>>();
        }

        public void Run()
        {
            var _command1 = _funcWithOneParameter(() => Console.WriteLine("Command1"));
            var _command2 = _funcWithOneParameter(() => Console.WriteLine("Command2"));
            var _command3 = _funcWithTwoParameters(() => Console.WriteLine("Command3"), true);
            var _command4 = _funcWithTwoParameters(() => Console.WriteLine("Command4"), true);
            _command1.Execute(this);
            _command2.Execute(this);
            _command3.Execute(this);
            _command4.Execute(this);
            Console.ReadKey();
            }
    }
}
