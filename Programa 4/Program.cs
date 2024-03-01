Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("ADIVINA EL NUMERO");
Console.ResetColor();


Random random = new Random();
int numsecreto = random.Next(1, 101);

int numUsuario;
int intentos = 0;

do
{
    Console.WriteLine("Introduce un numero entre 1 y 100");
    numUsuario = int.Parse(Console.ReadLine());

    intentos++;

    if (numUsuario > numsecreto)
    {
        Console.WriteLine("El numero secreto es menor que {0} ", numUsuario);
    }
    else if (numUsuario < numsecreto)
    {
        Console.WriteLine("El numero secreto es mayor que {0}", numUsuario);
    }
} while (numUsuario != numsecreto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Felicidades lo has adivinado en {0} intentos", intentos);
            Console.ResetColor();