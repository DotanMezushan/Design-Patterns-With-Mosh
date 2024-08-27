using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Exercises
{
    public class History
    {
        private List<DocumentState> _history = new List<DocumentState>();

        public void Push(DocumentState state)
        {
            _history.Add(state);
        }

        public DocumentState Pop()
        {

            var lastItem = _history[_history.Count - 1];

            _history.RemoveAt(_history.Count - 1);

            if (_history.Count - 1 >= 0)
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
