using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    public class History
    {
        private List<EditorState> _history = new List<EditorState>();

        public void Push(EditorState state)
        {
            _history.Add(state);
        }

        public EditorState Pop()
        {

            var lastItem = _history[_history.Count - 1];

            _history.RemoveAt(_history.Count - 1);

            if(_history.Count - 1 >= 0)
            {
                return _history[_history.Count - 1];

            }
            else
            {
                throw new InvalidOperationException("No state to undo.");
            }
        }


        public bool HasStates => _history.Count > 1;
    }
}
