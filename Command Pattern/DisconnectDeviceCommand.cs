using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{

    public class DisconnectDeviceCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Disconnecting from device...");
        }
    }
}
