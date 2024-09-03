using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class ConnectDeviceCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Connecting to device...");
        }
    }
}
