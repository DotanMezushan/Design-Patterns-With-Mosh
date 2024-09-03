using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern_ex1
{
    public class Editor
    {
        private ICommand _command;
        private readonly Stack<ICommand> _history = new Stack<ICommand>();

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
            _history.Push(_command);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                ICommand command = _history.Pop();
                command.Undo();
            }
        }
    }
}
