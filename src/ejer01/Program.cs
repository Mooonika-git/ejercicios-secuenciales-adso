int a, b, cambio;
Console.WriteLine("Ingrese primer numero:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero:");
b = int.Parse(Console.ReadLine());

cambio = a;
a = b;
b = cambio;

Console.WriteLine("Valores intercambiados:");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
