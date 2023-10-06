using Helpers;
namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Zoo with inheritance!");

        var az = new csAfricanZoo();
        Console.WriteLine(az);
        Console.WriteLine($"Kg meat eaten: {az.kgMeat}");

        var ez = new csEuropeanZoo();
        Console.WriteLine(ez);
        Console.WriteLine($"Number of Wolfs: {ez.nrWolfs}");

        var bz = new csBirdZoo();
        Console.WriteLine(bz);
        Console.WriteLine($"Number of Parrots: {bz.nrParrots}");


        List<csZoo> zoos = new List<csZoo>();
        zoos.Add(az);
        zoos.Add(ez);
        zoos.Add(bz);

        foreach (var item in zoos)
        {
            Console.WriteLine(item);
            Console.WriteLine($"Kg meat eaten: {item.kgMeat}");
            Console.WriteLine($"Number of Wolfs: {item.nrWolfs}");
            Console.WriteLine($"Number of Parrots: {item.nrParrots}");
        }
    }
}

