double nota1, nota2, nota3, definitiva;

Console.Write("Ingrese la nota del primer corte: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la nota del segundo corte: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la nota del tercer corte: ");
nota3 = Convert.ToDouble(Console.ReadLine());

definitiva = (nota1 * 0.25) + (nota2 * 0.35) + (nota3 * 0.40);

Console.WriteLine("La nota definitiva es: " + definitiva);