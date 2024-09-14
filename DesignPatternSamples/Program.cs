//using DesignPatternSamples.Creational.Singleton.Problem;
using DesignPatternSamples.Creational.AbstractFactory.Solution;
using DesignPatternSamples.Creational.Builder.Solution;
using DesignPatternSamples.Creational.Factory.Solution;
using DesignPatternSamples.Creational.Singleton.Solution;
using DesignPatternSamples.Structural.Adapter.Problem;
using DesignPatternSamples.Structural.Adapter.Problem.AvaFilters;
using DesignPatternSamples.Structural.Adapter.Solution;
using DesignPatternSamples.Structural.Composite.Problem;
using DesignPatternSamples.Structural.Decorator.Solution;
using DesignPatternSamples.Structural.Facade.Problem;
using DesignPatternSamples.Structural.Facade.Solution;
using System.Globalization;

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
            //new ContactForm().Render(new MaterialWidgetFactory());

            // Builder
            //var presentation = new Presentation();
            //presentation.AddSlide(new Creational.Builder.Problem.Slide("Intro Page"));
            //presentation.AddSlide(new Creational.Builder.Problem.Slide("Main Page"));
            //presentation.AddSlide(new Creational.Builder.Problem.Slide("Summary Page"));

            //var builder = new MovieBuilder();
            //presentation.Export(builder);
            //builder.getMovie();

            //var builder2 = new PdfDocumentBuilder();
            //presentation.Export(builder2);
            //builder2.GetPdfDocument();

            // Composite
            //var group1 = new Group();
            //group1.Add(new Shape());
            //group1.Add(new Shape());
            //group1.Render();


            //var group2 = new Group();
            //group2.Add(new Shape());
            //group2.Add(new Shape());
            //group2.Render();

            //var group = new Group();
            //group.Add(group1);
            //group.Add(group2);


            //Adapter 
            //var imageView = new ImageView(new Image());
            //imageView.Apply(new VividFilter());

            ////Use third party filter
            //var caramelFilter = new Caramel();
            //caramelFilter.Init();

            //// caramaelFilter doesn't implement IFilter
            ////imageView.Apply(caramelFilter);

            //imageView.Apply(new CaramelFilter(new Caramel()));

            // Decorator
            //var stream = new EncryptedCloudStream(new CompressedCloudStream(new CloudStream()));
            //stream.Write("sensitive data");

            // Facade

            //problem
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("AppId", "key");
            var message = new Message("Hello World");
            server.Send(authToken, message, "target");
            connection.Disconnect();

            //solution
            var service = new NotificationService();
            service.Send("Hello World", "target");
        }
    }
}
