using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Commands
{
    public class Messager : IMessager
    {
        private string _text;
        public Messager(string text)
        {
            _text = text;
        }

        public void WriteString()
        {
            Console.WriteLine(_text);
        }
    }
}
