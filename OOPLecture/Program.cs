// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Food Apple = new Food("Apple",false,100,0.49);

Console.WriteLine(Apple.Name);
// Apple.Name = "P";
Apple.PrintInfo();

Fruit Kiwi = new Fruit("Kiwi",false,60,0.39,true);

Kiwi.PrintInfo(5);

Food Generic = new Food();

Generic.PrintInfo();

static void MyMethod(params int[] values)
{
    foreach (int num in values)
    {
        Console.WriteLine(num);
        
    }
}

MyMethod(1);
MyMethod(7,8,3,3,4);