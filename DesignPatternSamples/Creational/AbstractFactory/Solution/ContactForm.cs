using DesignPatternSamples.Creational.AbstractFactory.Problem.Ant;
using DesignPatternSamples.Creational.AbstractFactory.Problem.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.AbstractFactory.Solution
{
    public class ContactForm
    {
        public void Render(IWidgetFactory widgetFactory) 
        {
            widgetFactory.CreateTextbox().Render();
            widgetFactory.CreateButton().Render();
        }
    }
}
