using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Singleton.Solution
{
    public class ConfigManager
    {
        Dictionary<string, object> settings = new Dictionary<string, object>();
        private static ConfigManager instance = new ConfigManager();

        private ConfigManager() { }

        public static ConfigManager getInstance() { return instance; }

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
