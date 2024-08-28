using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Tools
{
    public class BrushTool : ITool
    {
        public void MouswDown()
        {
            Console.WriteLine("MouswDown ToolType.BRUSH Icon");
        }

        public void MouswUp()
        {
            Console.WriteLine("MouswDown ToolType.BRUSH Icon");
        }
    }
}
