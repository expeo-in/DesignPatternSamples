using DesignPatternSamples.Creational.AbstractFactory.Problem.Material;
using DesignPatternSamples.Creational.AbstractFactory.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSamples.Creational.AbstractFactory.Problem.Ant;

namespace DesignPatternSamples.Creational.AbstractFactory.Solution
{
    public class AntWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new AntButton();
        }

        public ITextbox CreateTextbox()
        {
            return new AntTextbox();
        }
    }
}
