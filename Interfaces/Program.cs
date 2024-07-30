// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Bird birb = new();

Hawk RedTail = new("RedTail");
Ostrich Ozzy = new("Ozzy");
Duck Donald = new("Donald");

List<Bird> AllBirds = [RedTail,Ozzy,Donald];
List<IFly> Flyers = [RedTail, Donald];
foreach (Bird bird in AllBirds)
{
    if (bird is IFly f)
    {
        f.Fly();
    }
    else if (bird is IRun r)
    {
        r.Run();
    }
    else if (bird is ISwim s)
    {
        s.Swim();
    }
}