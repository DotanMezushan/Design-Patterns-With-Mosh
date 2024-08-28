using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Tools
{
    public class EraserTool : ITool
    {
        public void MouswDown()
        {
            Console.WriteLine("MouswDown Drow Eraser Icon");
        }

        public void MouswUp()
        {
            Console.WriteLine("MouswUp Drow Eraser Icon");
        }
    }
}
