using DesignPatternSamples.Behavioral.Memento.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Memento.Problem
{
    public class Editor
    {
        private string content = string.Empty;
        Stack<EditorState> prevStates = new Stack<EditorState>();

        public string Content { 
            get => content; 
            set {
                prevStates.Push(new EditorState(content));
                content = value;
            }
        }
        
        public void Restore()
        {
            var state = prevStates.Pop();
            content = state.Content;
        }
    }
}
