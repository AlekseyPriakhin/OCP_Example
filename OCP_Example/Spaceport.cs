public class Spaceport
{
    public Ship Build(IBuilder builder)
    {
        return builder.Build();
    }
}