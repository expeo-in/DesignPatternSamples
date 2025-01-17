﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.Solution
{
    internal class ListBox : UIControl
    {
        private string selection;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string Selection
        {
            get => selection;
            set
            {
                selection = value;
                owner.Changed(this);
            }
        }
    }
}
