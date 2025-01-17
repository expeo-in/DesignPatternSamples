﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Memento.Solution
{
    public class History
    {
        Stack<EditorState> states = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState Pop()
        {
            return states.Pop();
        }
    }
}
