using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    public class Editor
    {
        private string content;

        public void SetContent(string newContent)
        {
            content = newContent;
        }

        public string GetContent()
        {
            return content;
        }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState editorState)
        {
            content = editorState.GetContent();
        }
    }
}
