namespace DesignPatternSamples.Creational.Factory.Problem
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}
