class Hawk : Bird, IFly
{
    public int AirSpeed { get; set; } = 72;

    public Hawk(string name) : base(name){}

    public void Fly()
    {
        Console.WriteLine($"{Name} takes to sky at a rate of {AirSpeed} mph");
    }
}