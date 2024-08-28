using State.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Canvas : ICanvas
    {
        private ITool _currentTool;

        public ITool GetCurrentTool()
        {
            return _currentTool;
        }

        public void SetCurrentTool(ITool currentTool)
        {
            this._currentTool = currentTool;
        }

        public void MouswDown()
        {
            _currentTool.MouswDown();
        }


        public void MouswUp() 
        {
            _currentTool.MouswUp();
        }
    }
}
