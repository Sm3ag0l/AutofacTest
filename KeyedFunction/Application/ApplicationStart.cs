using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KeyedFunction.Controller;
using KeyedFunction.DataService;
using KeyedFunction.Interfaces;

namespace KeyedFunction.Application
{
    public class ApplicationStart : IApplicationStart
    {
        private IHomeController _controller;

        public ApplicationStart(IHomeController controller)
        {
            _controller = controller;
        }

        public void Run()
        {
            _controller.UseService(RoleName.Premium);
            _controller.UseService(RoleName.Normal);
            Console.ReadKey();
        }
    }
}
