﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Factory.Solution
{

    public class MatchaViewEngine: IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View Rendered by Matcha";
        }
    }
}
