//using DesignPatternSamples.Creational.Singleton.Problem;

//using DesignPatternSamples.Behavioral.Iterator.Problem;
using DesignPatternSamples.Behavioral.Command.Solution;
using DesignPatternSamples.Behavioral.Iterator.Solution;
using DesignPatternSamples.Behavioral.Memento.Solution;
using DesignPatternSamples.Behavioral.State.Solution;
using DesignPatternSamples.Behavioral.Strategy.Solution;
using DesignPatternSamples.Behavioral.Template.Solution;



//using DesignPatternSamples.Behavioral.Memento.Problem;
using DesignPatternSamples.Creational.AbstractFactory.Solution;
using DesignPatternSamples.Creational.Builder.Solution;
using DesignPatternSamples.Creational.Factory.Solution;
using DesignPatternSamples.Creational.Singleton.Solution;
using DesignPatternSamples.Structural.Adapter.Problem;
using DesignPatternSamples.Structural.Adapter.Problem.AvaFilters;
using DesignPatternSamples.Structural.Adapter.Solution;
using DesignPatternSamples.Structural.Bridge.Solution;
using DesignPatternSamples.Structural.Composite.Problem;
using DesignPatternSamples.Structural.Decorator.Solution;
using DesignPatternSamples.Structural.Facade.Problem;
using DesignPatternSamples.Structural.Facade.Solution;
using DesignPatternSamples.Structural.Flyweight.Solution;
//using DesignPatternSamples.Structural.Proxy.Problem;
using DesignPatternSamples.Structural.Proxy.Solution;
using System.Globalization;
using System.Net.Http.Headers;

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
            ////problem
            //var server = new NotificationServer();
            //var connection = server.Connect("ip");
            //var authToken = server.Authenticate("AppId", "key");
            //var message = new Message("Hello World");
            //server.Send(authToken, message, "target");
            //connection.Disconnect();

            ////solution
            //var service = new NotificationService();
            //service.Send("Hello World", "target");

            // Flyweight
            //var pointService = new PointService(new PointIconFactory());
            //foreach (var point in pointService.GetPoints())
            //{
            //    point.Draw();
            //}

            // Bridge
            //var remoteControl = new RemoteControl(new SonyTV());
            //remoteControl.TurnOn();
            //var remoteControl = new AdvancedRemoteControl(new SamsungTV());
            //remoteControl.TurnOn();

            //Proxy

            //Problem
            //string[] filenames = {"a", "b", "c"};
            //var library = new Library();
            //foreach (var filename in filenames) {
            //    //library.AddEbook(new Ebook(filename));
            //    library.AddEbook(new EbookProxy(filename));
            //}

            // Proxy
            //string[] filenames = { "a", "b", "c" };
            //var library = new Library();
            //foreach (var filename in filenames)
            //{
            //    //library.AddEbook(new Ebook(filename));
            //    library.AddEbook(new EbookProxy(filename));
            //}

            //library.OpenEbook("a");

            // Memento
            //// Problem
            //Editor editor = new Editor();
            //editor.Content = "a";
            //editor.Content = "b";
            //editor.Content = "c";
            //editor.Restore();
            //editor.Restore();
            //Console.WriteLine(editor.Content);

            //Editor editor = new Editor();
            //History history = new History();
            //editor.Content = "a";
            //history.Push(editor.CreateState());

            //editor.Content = "b";
            //history.Push(editor.CreateState());

            //editor.Content = "c";
            //editor.Restore(history.Pop());
            //editor.Restore(history.Pop());

            //Console.WriteLine(editor.Content);


            // State
            //var canvas = new Canvas();
            //canvas.CurrentTool = new BrushTool();
            //canvas.MouseDown();
            //canvas.MouseUp();

            // Iterator
            //var browseHistory = new BrowseHistory();
            //browseHistory.Push("a");
            //browseHistory.Push("b");
            //browseHistory.Push("c");
            //for (int i = 0; i < browseHistory.Urls.Count; i++)
            //{
            //    Console.WriteLine(browseHistory.Urls[i]);
            //}

            // Iterator
            //var browseHistory = new BrowseHistory();
            //browseHistory.Push("a");
            //browseHistory.Push("b");
            //browseHistory.Push("c");

            //var iterator = browseHistory.CreateIterator();
            //while (iterator.HasNext())
            //{
            //    var url = iterator.Current();
            //    Console.WriteLine(url);
            //    iterator.Next();
            //}

            // Strategy
            //var imageStorage = new ImageStorage(new JPGCompressor(), new BlackAndWhiteFilter());
            //imageStorage.Store("a");

            // Template
            //var transferMoneyTask = new TransferMoneyTask();
            //transferMoneyTask.Execute();

            //var generateReportTask = new GenerateReportTask();
            //generateReportTask.Execute();

            // Command

            CustomerService customerService = new CustomerService();
            AddCustomerCommand command = new AddCustomerCommand(customerService);
            Button button = new Button(command);
            button.Click();
        }
    }
}
