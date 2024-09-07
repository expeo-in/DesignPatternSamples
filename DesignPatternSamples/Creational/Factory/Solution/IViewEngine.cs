namespace DesignPatternSamples.Creational.Factory.Solution
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}
