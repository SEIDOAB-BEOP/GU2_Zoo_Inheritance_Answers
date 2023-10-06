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

        Console.WriteLine();
        Console.WriteLine("List of zoos");
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

            /*
            if (item is csAfricanZoo z1)
                Console.WriteLine($"Kg meat eaten: {z1.kgMeat}");

            if (item is csEuropeanZoo z2)
                Console.WriteLine($"Number of Wolfs: {z2.nrWolfs}");

            if (item is csBirdZoo z3)
                Console.WriteLine($"Number of Parrots: {z3.nrParrots}");
            */

        }

    }
}

