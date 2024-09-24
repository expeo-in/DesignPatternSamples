using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Memento.Solution
{
    public class EditorState
    {
        public string Content { get; init; }

        public EditorState(string content)
        {
            this.Content = content;
        }
    }
}
