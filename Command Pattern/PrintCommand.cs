using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class PrintCommand : ICommand
    {
        private readonly string _message;

        public PrintCommand(string message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine(_message);
        }
    }

}
