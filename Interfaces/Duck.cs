class Duck : Bird, IFly, ISwim
{
    public int AirSpeed { get ; set ; } = 8;
    public int NauticalSpeed { get ; set ; } = 9;
    public Duck(string name) : base(name){}


    public void Fly()
    {
        Console.WriteLine($"{Name} takes to sky at a rate of {AirSpeed} mph");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} paddles off at a rate of {NauticalSpeed} mph");
    }
}