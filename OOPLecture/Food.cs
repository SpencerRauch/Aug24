class Food
{
    // private string _name;
    // public string Name {get{return _name;}set{if(value.Length >1)_name = value;}}
    public string Name { get;set; }
    private bool IsWarm;
    private int Calories;
    private double Price;
    // public List<string> Cuisines = new List<string>();

    public Food(string name, bool isWarm, int calories, double price=0.00)
    {
        Name = name;
        IsWarm = isWarm;
        Calories = calories;
        Price = price;
    }

    public Food()
    {
        Name = "Default Food";
        IsWarm = true;
        Calories = 0;
        Price = 0;
    }

    public Food(string name, bool isWarm, int calories)
    {
        Name = name;
        IsWarm = isWarm;
        Calories = calories;
        Price = 0;
    }

     public Food(string name, bool isWarm, double price)
    {
        Name = name;
        IsWarm = isWarm;
        Calories = 1000;
        Price = price;
    }


    public virtual void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine($"IsWarm: {IsWarm}");
        Console.WriteLine($"Calories: {Calories}");
        Console.WriteLine($"Price: {Price}");
        
        
    }

    public virtual void PrintInfo(int times)
    {
        for (int i = 0; i < times; i++)
        {
            PrintInfo();
        }
        
        
    }
    public void PrintInfo(params int[] values)
    {
        foreach (int num in values)
        {
            PrintInfo(num);
        }
    }
}