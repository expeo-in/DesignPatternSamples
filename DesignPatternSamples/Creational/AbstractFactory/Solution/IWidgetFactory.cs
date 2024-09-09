using DesignPatternSamples.Creational.AbstractFactory.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.AbstractFactory.Solution
{
    public interface IWidgetFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}
