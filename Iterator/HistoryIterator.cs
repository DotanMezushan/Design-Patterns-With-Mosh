using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class HistoryIterator : IIterator<string>
    {
        private readonly List<string> _urls;
        private int _position = -1;

        public HistoryIterator(List<string> urls)
        {
            _urls = urls;
        }

        public string Current => _urls[_position];

        public bool MoveNext()
        {
            _position++;
            return _position < _urls.Count;
        }
    }

}
