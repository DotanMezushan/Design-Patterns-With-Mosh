using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Tools
{
    public class SelectionTool : ITool
    {
        public void MouswDown()
        {
            Console.WriteLine("MouswDown Drow SELECTION Icon");
        }

        public void MouswUp()
        {
            Console.WriteLine("MouswUp Drow SELECTION Icon");
        }
    }
}
