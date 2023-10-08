public class Spaceport
{
    public Ship Build(object builder)
    {
        return builder switch
        {
            CruiserBuilder b => b.BuildCruiser(),
            ContsructorShipBuilder b => b.BuildContsructorShip(),
            _ => throw new Exception("Unknown builder"),
        };
    }
}