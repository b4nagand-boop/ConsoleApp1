// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// for(int i=0; i < 100; i++)
// {
//     Console.WriteLine("Laci");
// }

// for (int i = 100; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// Console.Write("Az intervallum alsó végpontja > ");
// int alsoVegpont = int.Parse(Console.ReadLine());
// Console.Write("Az intervallum felső végpontja > ");
// int felsoVegpont = int.Parse(Console.ReadLine());

// int parosSzamOsszeg = 0;
// for (int i = alsoVegpont; i <= felsoVegpont; i++)
// {
//     if (i%2 == 0)
//     {
//         parosSzamOsszeg += i;
//     }
// }

// Console.WriteLine($"A(z) [{alsoVegpont}; {felsoVegpont}] intervallumba eső páros számok összege > {parosSzamOsszeg}");

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{j*i} ");
    }
    Console.WriteLine();
}