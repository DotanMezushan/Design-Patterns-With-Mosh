using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Exercises
{
    public class DocumentState
    {
        public readonly string _content;
        public readonly string _fontName;
        public readonly float _fontSize;

        public DocumentState(string content, string fontName, float fontSize)
        {
            this._content = content;
            this._fontName = fontName;
            this._fontSize = fontSize;
        }

        public DocumentState GetContent()
        {
            return new DocumentState(_content,_fontName,_fontSize);
        }
    }
}
