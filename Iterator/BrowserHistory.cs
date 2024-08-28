using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BrowserHistory : IHistory
    {
        private readonly List<string> _urls = new List<string>();

        public void AddUrl(string url)
        {
            _urls.Add(url);
        }

        public IIterator<string> CreateIterator()
        {
            return new HistoryIterator(_urls);
        }
    }
}
