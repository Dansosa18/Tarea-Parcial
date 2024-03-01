using System.Collections.Generic;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\t\t*****************************");
Console.WriteLine("\t\t*        PROPIEDADES        *");
Console.WriteLine("\t\t*****************************\n");
Console.ResetColor();


//Length: Longitud de la cadena.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Length: Obtiene la longitud de una cadena");
Console.ResetColor();

string nombre = "Daniel Sosa";
Console.WriteLine(nombre);
int longitud = nombre.Length;
Console.WriteLine($"La longitud de la cadena es: {longitud} ");

//IsReadOnly: Indica si la cadena es de solo lectura.



//Chars: Obtiene un array de caracteres que componen la cadena

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nChars: Obtiene un array de caracteres que componen la cadena");
Console.ResetColor();


string nombre1 = "Daniel Sosa";
char primerCaracter = nombre1[0];

foreach (char caracter in nombre1)
{
    Console.WriteLine(caracter);
}

char ultimoCaracter = nombre[nombre1.Length - 1]; 
char[] caracteres = nombre.ToCharArray();

