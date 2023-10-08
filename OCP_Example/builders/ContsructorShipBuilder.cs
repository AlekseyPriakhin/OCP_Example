public class ContsructorShipBuilder : IBuilder
{
    public Ship Build(){
        System.Console.WriteLine("Build Constructor Ship");
        return new ContsructorShip();
    }
}