class Fruit : Food
{
    public bool IsRipe;

    public Fruit(string name, bool isWarm, int calories, double price, bool isRipe):base(name, isWarm, calories, price)
    {
        IsRipe = isRipe;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"IsRipe: {IsRipe}");
    }
}