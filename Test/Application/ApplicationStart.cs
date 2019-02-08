using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test.Commands;
using Test.Interfaces;

namespace Test.Application
{
    public class ApplicationStart : IApplicationStart
    {
        private IMessager _messager;
        private ICommand _command;
        private IContainer _container;
        private readonly Func<Action, ICommand> _func;
        

        public ApplicationStart(IMessager messager, Func<Action,ICommand> func)
        {
            _messager = messager;
            _container = Container.Container.Config();
            _func = _container.Resolve<Func<Action, ICommand>>();    
            
        }

        public void Run()
        {
            _messager.WriteString();
            //_command.Execute(this);
            _command = _func(()=>Console.WriteLine("Holla es funktioniert"));
            _command.Execute(this);
            Console.ReadKey();
        }
    }
}
