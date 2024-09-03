using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern_ex1
{
    public class Document
    {
        private string _content = "";

        public void AddText(string text)
        {
            _content += text;
            Console.WriteLine($"Document content: {_content}");
        }

        public void RemoveText(string text)
        {
            if (_content.EndsWith(text))
            {
                _content = _content.Substring(0, _content.Length - text.Length);
                Console.WriteLine($"Document content: {_content}");
            }
        }
    }
}
