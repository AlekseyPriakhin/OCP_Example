public static class Player {
    
    private static object hero;
    public static void SetHero(object _hero)
    {
        hero = _hero;
    }

    public static void UseAbility()
    {
        if(hero is null) System.Console.WriteLine("Hero not set");

        if(hero is Ashe)
        {
            var h = (Ashe)hero;
            h.ThrowDynamite();
        }
        if(hero is Winston)
        {
            var h = (Winston)hero;
            h.SetBarier();
        }
    }

}