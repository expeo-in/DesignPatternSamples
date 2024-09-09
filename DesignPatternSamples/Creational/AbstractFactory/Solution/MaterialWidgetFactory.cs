using DesignPatternSamples.Creational.AbstractFactory.Problem;
using DesignPatternSamples.Creational.AbstractFactory.Problem.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.AbstractFactory.Solution
{
    public class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ITextbox CreateTextbox()
        {
            return new MaterialTextbox();
        }
    }
}
