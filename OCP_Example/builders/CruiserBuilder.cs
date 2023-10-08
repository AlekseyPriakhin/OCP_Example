public class CruiserBuilder : IBuilder
{
    public Ship Build()
    {
        System.Console.WriteLine("Build Cruiser");
        return new Cruiser();
    }
}