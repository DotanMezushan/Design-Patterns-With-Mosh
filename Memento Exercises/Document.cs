using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Memento_Exercises
{
    public class Document
    {
        private string _content;
        private string _fontName;
        private float _fontSize;

        public void SetContent(string newContent)
        {
            _content = newContent;
        }

        public void SetFontName(string newFontName)
        {
            _fontName = newFontName;
        }

        public void SetFontSize(float newFontSize)
        {
            _fontSize = newFontSize;
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetFontName()
        {
            return _fontName;
        }

        public float GetFontSize()
        {
            return _fontSize;
        }


        public DocumentState CreateState()
        {
            return new DocumentState(_content, _fontName, _fontSize);
        }

        public void Restore(DocumentState documentState)
        {
            var _documentState = documentState.GetContent();
            this._content = _documentState._content;
            this._fontName = _documentState._fontName;
            this._fontSize = _documentState._fontSize;
        }

        public override string ToString()
        {
            return $"Document values " +
                   $"\ncontent: {_content} " +
                   $"\nFontName: {_fontName} " +
                   $"\nFontSize: {_fontSize} \n";
        }

    }
}
