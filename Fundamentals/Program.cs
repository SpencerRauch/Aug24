// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

int Age = 36;

string Name = "Spencer";
char Character = 'C';


Console.WriteLine($"My name is {Name} and I am {Age} years old");

if (Age >= 36)
{
    Console.WriteLine("Yeah gettin p old, Spence");
}

string[] Strings = new string[3];
Console.WriteLine(Strings[1]);

int[] Integers = new int[20];
Console.WriteLine(Integers[4]);

for (int i = 0; i < Integers.Length; i++)
{
    Integers[i] = i;
    Console.WriteLine($"{i},{Integers[i]}");
}

foreach (int number in Integers)
{
    Console.WriteLine(number);
    
}

// List<string> Names = new List<string>();
// List<string> Names = new();
List<string> Names = ["Christian", "Melissa", Name];

List<string> NamesTwo = new()
{
    "Christian",
    "Spencer"
};

Names.ForEach(Console.WriteLine);

Dictionary<string, int> PetAges = new()
{
    {"Wiley",5},
    {"Honey",5}
};

PetAges["Wiley"] = 6;

foreach (KeyValuePair<string,int> entry in PetAges)
{
    Console.WriteLine($"The key is {entry.Key} the value is {entry.Value} ");
    
}

static void SayHello()
{
    Console.WriteLine("Hello how are you doing today?");
}

SayHello();

static int MathingTheMath(int numOne, int numTwo=8)
{
    return numOne * numTwo;
}

// static int MathingTheMath(int numOne)
// {
//     return numOne * 8;
// }

int Product = MathingTheMath(4,8);
Console.WriteLine(Product);


