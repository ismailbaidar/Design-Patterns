using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class TextEditor
    {
        public string Content { get; set; }
        public TextEditor(string content)
        {
            Content = content;
        }

        public TextEditorMemento CreateMemento()
        {
            return new TextEditorMemento(Content);
        }

        public void RestoreMemento(TextEditorMemento memento) 
        {
            Content = memento.Content;
        }
    }
}
