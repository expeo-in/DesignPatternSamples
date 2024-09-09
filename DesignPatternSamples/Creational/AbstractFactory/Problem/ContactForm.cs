using DesignPatternSamples.Creational.AbstractFactory.Problem.Ant;
using DesignPatternSamples.Creational.AbstractFactory.Problem.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.AbstractFactory.Problem
{
    public enum Theme
    {
        Material,
        Ant
    }
    public class ContactForm
    {
        public void Render(Theme theme) 
        {
            if (theme == Theme.Material)
            {
                new MaterialTextbox().Render();
                new MaterialButton().Render();
            }
            else if (theme == Theme.Ant)
            {
                new AntTextbox().Render();
                new AntButton().Render();
            }
        }
    }
}
