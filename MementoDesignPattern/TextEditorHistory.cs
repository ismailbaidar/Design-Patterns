using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class TextEditorHistory
    {
        private Stack<TextEditorMemento> Mementos = new Stack<TextEditorMemento>();

        public void Push(TextEditorMemento memento)
        {
            Mementos.Push(memento);
        }
        public TextEditorMemento Restore()
        {
            TextEditorMemento memento = Mementos.Pop();
            return memento;
        }
    }
}
