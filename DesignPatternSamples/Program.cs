//using DesignPatternSamples.Creational.Singleton.Problem;
using DesignPatternSamples.Creational.AbstractFactory.Solution;
using DesignPatternSamples.Creational.Factory.Solution;
using DesignPatternSamples.Creational.Singleton.Solution;

namespace DesignPatternSamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Singleton Problem Code
            //ConfigManager configManager1 = new ConfigManager();
            //configManager1.Set("name", "gof");

            //ConfigManager configManager2 = new ConfigManager();
            //Console.WriteLine(configManager2.Get("name"));


            // Singleton Solution Code
            //ConfigManager configManager1 = ConfigManager.getInstance();
            //configManager1.Set("name", "gof");

            //ConfigManager configManager2 = ConfigManager.getInstance();
            //Console.WriteLine(configManager2.Get("name"));

            // Factory Method
            //ProductsController controller = new ProductsController();
            //controller.ListProducts();

            // Abstract Factory
            new ContactForm().Render(new MaterialWidgetFactory());
        }
    }
}
