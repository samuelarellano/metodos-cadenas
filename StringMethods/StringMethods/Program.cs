// See https://aka.ms/new-console-template for more information

using System.Text;

string cadena = "Samuel Arellano";
char letra  = 'a';

char[] chars = cadena.ToCharArray();

for (int i = 0; i < chars.Length; i++)
{
    Console.WriteLine(chars[i]);
}

Console.WriteLine("La longitud de mi cadena es: " + cadena.Length);

Console.WriteLine(cadena.ToUpper());
Console.WriteLine(cadena.ToLower());

bool findA = cadena.ToUpper().Contains("A");
Console.WriteLine(findA);

cadena = cadena.Replace("Samuel", "Andreé");
Console.WriteLine(cadena);


cadena = cadena.Substring(7, cadena.Length-7);
Console.WriteLine(cadena);

// Forma 1 de concatenar cadenas
Console.WriteLine("La longitud de mi cadena es: " + cadena.Length);

//Forma 2 es utilizando String.Concat

cadena = string.Empty;
cadena = string.Concat("Enrique", " Valero");

Console.WriteLine(cadena);

//bool validateName = cadena == "Enrique Valero";

bool validateName = cadena.Equals("Enrique Valero");
Console.WriteLine($"El nombre es válido o no ? {validateName} ");

// Forma 3 es con un String.Format
cadena = string.Format("La longitud de la cadena es: {0}", cadena.Length);
Console.WriteLine(cadena);

//Forma 4 interpolación (String Interpolation)
Console.WriteLine($"El nombre del alumno es: {cadena} y la longitud es {cadena.Length} y trabaja en TP");

// Forma 5 alternativa String.Builder
var stringBuilder = new StringBuilder();
stringBuilder.Append(cadena);
stringBuilder.Append(" Esta es otra cadena larga");
Console.WriteLine(stringBuilder.ToString());

var valor = "50";
int entero = int.Parse(valor);

valor = "50x";
bool isValid = int.TryParse(valor, out entero);

if(isValid)
{
    Console.WriteLine("El parseo de string a entero fue satisfactorio");
}
else
{
    Console.WriteLine("No puedes convertir una cadena inválida a entero");
}

string fechaActual = "04/17/2024";
DateTime fecha;
var isFecha = DateTime.TryParse(fechaActual, out fecha);

if (isFecha)
    Console.WriteLine(fecha);

string file = "C:\\file.text";
Console.WriteLine(file);

//Verbatim string
file = @"C:\sarellano\source\repos\MiCodigo";
Console.WriteLine(file);