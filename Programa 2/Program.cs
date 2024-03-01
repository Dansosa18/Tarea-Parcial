Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("OPERADORES");
Console.ResetColor();

int num1, num2;
string operador;
bool valido = false;


Console.WriteLine("Introduzca el primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduzca el segundo numero");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("\nAhora introduzca el operador con el que desea trabajar (+, -, *, /)\n");
operador = Console.ReadLine();


switch (operador)
{
    case "+":
        Console.WriteLine("\nEligio suma");
        Console.WriteLine($"El resultado de la suma de los 2 numeros es: {num1 + num2} ");
        break;

    case "-":
        Console.WriteLine("\nEligio resta");
        Console.WriteLine($"El resulado de la resta de los 2 numeros es: {num1 - num2}");
        break;

    case "*":
        Console.WriteLine("\nEligio multiplicacion");
        Console.WriteLine($"El resultado de la multiplicacion de los 2 numeros es: {num1 * num2}");
        break;
    case "/":
        Console.WriteLine("\nEligio division");
        Console.WriteLine($"El resultado de la division de los 2 numeros es: {num1 / num2}");
        break;
    default:
        Console.WriteLine("No es un operador");
        break;

}
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("\nEso es todo GRACIAS");
Console.ResetColor();