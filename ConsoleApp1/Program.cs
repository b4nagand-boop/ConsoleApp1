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




// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.Write($"{j*i} ");
//     }
//     Console.WriteLine();
// }




// int x = 0;
// do
// {
//     Console.Write("Adj meg egy számot > ");
//     x = int.Parse(Console.ReadLine());
// } while (x <= 0);




// List<string> autok = new();
// autok.Add("McLaren");
// autok.Add("Honda");
// autok.Add("BMW");
// autok.Add("Renault");
// autok.Add("BYD");
// autok.Add("Tesla");
// autok.Add("Subaru");

// Console.WriteLine(autok);
// Console.WriteLine(autok[0]);
// //autok.Remove("McLaren");
// Console.WriteLine(autok.Count);

// foreach (string auto in autok)
// {
//     Console.WriteLine(auto);
// }




// Console.Write("Add meg a csoki gyártási sorszámát > ");
// int sorszam = int.Parse(Console.ReadLine());

// bool vanEOszto = false;
// for (int i = 2; i < sorszam; i++)
// {
//     if (sorszam % i == 0)
//     {
//         vanEOszto = true;
//     }
// }

// if (sorszam <= 1 || vanEOszto)
// {
//     Console.WriteLine("Sajnos nem nyert!");    
// } else
// {
//     Console.WriteLine("Gratulálunk, nyertél!");
// }
























List<string> gyumolcsok = new();
for (int i = 1; i <= 5; i++) {
    Console.Write($"Add meg az {i}. gyümölcsöt > ");
    gyumolcsok.Add(Console.ReadLine());
}

Console.Write("\n[");
foreach (string gyumolcs in gyumolcsok) {
    if (gyumolcs == gyumolcsok.Last()) {
        Console.Write($"'{gyumolcs}'");
    } else {
        Console.Write($"'{gyumolcs}', ");
    }
}
Console.WriteLine("]\n");




List<int> jegyek = new();
for (int i = 1; i <= 10; i++) {
    Console.Write($"Add meg az {i}. tanuló jegyét > ");
    jegyek.Add(int.Parse(Console.ReadLine()));
}

int osszeg = 0;
Console.Write("\nJegyek > ");
foreach (int jegy in jegyek) {
    Console.Write($"{jegy} ");
    osszeg += jegy;
}

double atlag = (double)osszeg / jegyek.Count;
Console.WriteLine($"\nAz osztály átlaga > {atlag}");

Console.Write("\nJegyek sorrend > ");
jegyek.Sort();
foreach (int jegy in jegyek) {
    Console.Write($"{jegy} ");
}

Console.Write("\nJegyek sorrend2 > ");
jegyek.Reverse();
foreach (int jegy in jegyek) {
    Console.Write($"{jegy} ");
}

Console.WriteLine($"\nLegjobb jegy > {jegyek.Max()}");
Console.WriteLine($"Legrosszabb jegy > {jegyek.Min()}\n");




List<string> honapok = ["Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December"];
List<int> koltsegek = new();
int osszeg2 = 0;

for (int i = 0; i < 12; i++) {
    Console.Write($"{honapok[i]} > ");
    int ckoltseg = int.Parse(Console.ReadLine());
    koltsegek.Add(ckoltseg);
    osszeg2 += ckoltseg;
}

Console.WriteLine($"Éves költség > {osszeg2}");
Console.WriteLine($"Átlagos havi költség > {(double)osszeg2 / koltsegek.Count}\n");




Console.Write("Add meg a termékek darabszámát: ");
int termekDb = int.Parse(Console.ReadLine());

List<int> eredetiArak = new();
for (int i = 1; i <= termekDb; i++) {
    Console.Write($"Add meg az {i}. termék árát: ");
    eredetiArak.Add(int.Parse(Console.ReadLine()));
}

List<int> akciosArak = new();
foreach (int ar in eredetiArak) {
    akciosArak.Add((int)(ar * 0.7));
}

Console.Write("Eredeti árak: [");
foreach (int ar in eredetiArak) {
    if (ar == eredetiArak.Last()) {
        Console.Write(ar);
    } else {
        Console.Write($"{ar}, ");
    }
}
Console.WriteLine("]");

Console.Write("Az akciós árak: [");
foreach (int ar in akciosArak) {
    if (ar == akciosArak.Last()) {
        Console.Write(ar);
    } else {
        Console.Write($"{ar}, ");
    }
}
Console.WriteLine("]");

int akciosOsszeg = 0;
foreach (int ar in akciosArak) {
    akciosOsszeg += ar;
}

double akciosAtlag = (double)akciosOsszeg / akciosArak.Count;
Console.WriteLine($"Az akciós átlagár: {akciosAtlag}\n");




Console.Write("Hallgató jegyeinek száma: ");
int osztondijDb = int.Parse(Console.ReadLine());

List<int> osztondijJegyek = new();
for (int i = 1; i <= osztondijDb; i++) {
    Console.Write($"{i}. jegy: ");
    osztondijJegyek.Add(int.Parse(Console.ReadLine()));
}

int osztondijOsszeg = 0;
foreach (int jegy in osztondijJegyek) {
    osztondijOsszeg += jegy;
}

double osztondijAtlag = (double)osztondijOsszeg / osztondijJegyek.Count;
Console.WriteLine($"A jegyek átlaga: {osztondijAtlag:F1}");

if (osztondijAtlag >= 4.0) {
    Console.WriteLine("A hallgató ösztöndíjra jogosult!");
} else {
    Console.WriteLine("A hallgató nem jogosult ösztöndíjra!");
}