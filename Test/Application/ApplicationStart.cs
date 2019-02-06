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

        public ApplicationStart(IMessager messager, ICommand command)
        {
            _messager = messager;
            _command = command;
        }

        public void Run()
        {
            _messager.WriteString();
            _command.Execute(this);
            Console.ReadKey();
        }
    }
}
