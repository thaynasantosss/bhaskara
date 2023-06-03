double a, b, c, delta, x1, x2;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("\n*** Cálculo de Bhascara ***\n");
Console.ResetColor();

Console.Write("Por favor digite os valores\n");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("c: ");
c = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

if (a == 0)
{
    Console.Write("O valor de");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" a ");
    Console.ResetColor();
    Console.WriteLine("não pode ser zero");
}
else
{   
delta = b * b - 4 * a * c;

if (delta < 0)
{    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"O delta {delta:N2} é negativo!"); 
    Console.ResetColor();
    Console.WriteLine(" Portanto, não é possivel calcular as raízes!");
}

else
{
x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

Console.Write("As Raízes São x1 = ");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{x1:N2} ");
Console.ResetColor();

Console.Write("e ");
Console.Write("x2 = ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{x2:N2}");
Console.ResetColor();
}
}

Console.ReadKey();
Console.Clear();

// eu tentei, juro 😣