using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Commands;
using Test.Interfaces;

namespace Test.Application
{
    public class ApplicationStart : IApplicationStart
    {
        private IMessager _messager;

        public ApplicationStart(IMessager messager)
        {
            _messager = messager;
        }

        public void Run()
        {
            _messager.WriteString();
            Console.ReadKey();
        }
    }
}
