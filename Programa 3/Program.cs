Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("TABLA DE MULTIPLICARA");
Console.ResetColor();

Console.WriteLine("Introduzca un numero");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"La tabla de Multiplicar del {num} es:");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}