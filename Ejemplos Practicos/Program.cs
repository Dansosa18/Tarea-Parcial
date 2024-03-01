

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\t\t***************************");
Console.WriteLine("\t\t*        METODOS☻          *");
Console.WriteLine("\t\t***************************\n");
Console.ResetColor();


//Length: Obtiene la longitud de una cadena.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Length: Obtiene la longitud de una cadena");
Console.ResetColor();

string nombre = "Daniel Sosa";
Console.WriteLine(nombre);
int longitud = nombre.Length; 
Console.WriteLine($"La longitud de la cadena es: {longitud} ");

//ToUpper(): Convierte una cadena a mayúsculas.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nToUpper(): Convierte una cadena a mayúsculas.\r\n");
Console.ResetColor();

string saludo = "hola mundo";
Console.WriteLine(saludo);
string Mayuscula = saludo.ToUpper(); 
Console.WriteLine(Mayuscula);

//ToLower(): Convierte una cadena a minúsculas.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nToLower(): Convierte una cadena a minúsculas\n");
Console.ResetColor();


string ciudad = "CIUDAD DE GUATEMALA";
Console.WriteLine(ciudad);
string Minusculas = ciudad.ToLower(); 
Console.WriteLine(Minusculas);

//IndexOf(): Busca la primera ocurrencia de un caracter o cadena.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nIndexOf(): Busca la primera ocurrencia de un caracter o cadena.\n");
Console.ResetColor();

string frase = "Mañana ire al trabajo";
Console.WriteLine(frase);
int indice = frase.IndexOf("a");

Console.WriteLine("El índice de la primera 'a' es: {0}", indice);


//LastIndexOf(): Busca la última ocurrencia de un caracter o cadena.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nLastIndexOf(): Busca la última ocurrencia de un caracter o cadena.\n");
Console.ResetColor();

string frase1 = "Mañana ire al trabajo";
Console.WriteLine(frase1);
int indice1 = frase1.LastIndexOf("a");

Console.WriteLine("El índice de la última 'a' es: {0}", indice1);

//Substring(): Extrae una subcadena.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nSubstring(): Extrae una subcadena\n");
Console.ResetColor();

string nombreCompleto = "Victor Daniel Sosa Lopez";
Console.WriteLine(nombreCompleto);
string apellido = nombreCompleto.Substring(14);
Console.WriteLine("El apellido es: {0}", apellido);

//Replace(): Reemplaza una subcadena por otra.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nReplace(): Reemplaza una subcadena por otra.\n");
Console.ResetColor();


string mensaje = "Hola, soy Victor";
Console.WriteLine(mensaje);

string mensajeNuevo = mensaje.Replace("Victor", "Daniel");

Console.WriteLine("El nuevo mensaje es: {0}", mensajeNuevo);

//Trim(): Elimina espacios en blanco al inicio y final.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nTrim(): Elimina espacios en blanco al inicio y final.\n");
Console.ResetColor();

string texto = "     Hola mundo      ";
Console.WriteLine(texto);
string textoSinEspacios = texto.Trim();

Console.WriteLine("El texto sin espacios es: {0}", textoSinEspacios);

//StartsWith(): Indica si una cadena comienza con otra.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nStartsWith(): Indica si una cadena comienza con otra.\n");
Console.ResetColor();

string url = "https://www.google.com";
Console.WriteLine(url);
bool comienzaConHttps = url.StartsWith("https://");

Console.WriteLine("¿Comienza con https?: {0}", comienzaConHttps);

//EndsWith(): Indicar si una cadena termina con otra.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nEndsWith(): Indicar si una cadena termina con otra.\n");
Console.ResetColor();

string nombre3 = "Daniel Sosa";
Console.WriteLine(nombre3);
bool terminaConSosa = nombre3.EndsWith("Sosa");

Console.WriteLine("¿Termina con Sosa?: {0}", terminaConSosa);

