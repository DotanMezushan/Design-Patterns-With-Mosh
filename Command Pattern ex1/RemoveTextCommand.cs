using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern_ex1
{
    public class RemoveTextCommand : ICommand
    {
        private readonly Document _document;
        private readonly string _text;

        public RemoveTextCommand(Document document, string text)
        {
            _document = document;
            _text = text;
        }

        public void Execute()
        {
            _document.RemoveText(_text);
        }

        public void Undo()
        {
            _document.AddText(_text);
        }
    }
}
