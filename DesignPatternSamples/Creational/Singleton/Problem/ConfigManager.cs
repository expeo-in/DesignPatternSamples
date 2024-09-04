using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Singleton.Problem
{
    public class ConfigManager
    {
        Dictionary<string, object> settings = new Dictionary<string, object>();

        public void Set(string key, object value)
        {
            settings[key] = value;
        }

        public object Get(string key)
        {
            return settings[key];
        }
    }
}
