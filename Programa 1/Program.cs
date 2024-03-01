Console.ForegroundColor = ConsoleColor .Green;
Console.WriteLine("OPCION Y REPETIR");
Console.ResetColor();


int num, opcion;
bool salir= false;

Console.WriteLine("***************BIENVENIDO***************\n");

while (!salir)
{
    Console.WriteLine("\n\t*******MENU*******");
    Console.WriteLine("1. Calcular el factorial de un numero");
    Console.WriteLine("2. Calculat la raiz cuadradad de un numero");
    Console.WriteLine("3. Salir\n");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("\nIngrese un numero");
            num = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {num} es: {factorial}");
            break;

            case 2:
            Console.WriteLine("\nIngrese un numero");
            num = int.Parse(Console.ReadLine());

            double raiz = Math.Sqrt( num );
          
            Console.WriteLine($"\n La raiz cuadrada de {num} es: {raiz}");
            break;

            case 3:
            salir = true;
            break;

        default:
            Console.WriteLine("\nOpcion no valida. Introduzca un numero entre 1 y 3");
            break;
    }
}
Console.ForegroundColor= ConsoleColor .Green;
Console.WriteLine("\nEso es todo GRACIAS");
Console.ResetColor ();