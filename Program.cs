/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("Ingrese un numero");
string numero = Console.ReadLine();

if (int.TryParse(numero, out int numeroInvertir))
{
    if (numeroInvertir > 0)
    {
        int nuevoNumero = 0;
        while (numeroInvertir > 0)
        {
            int aux = numeroInvertir % 10;
            nuevoNumero = nuevoNumero * 10 + aux;
            numeroInvertir /= 10;
        }
        Console.WriteLine("Numero invertido: " +  nuevoNumero);
    }
    else
    {
        Console.WriteLine("No es un numero mayor a 0");
    }
}
else
{
    Console.WriteLine("Ingrese un numero valido");
} */

//Ejercicio 4

System.Console.WriteLine("Ingrese una cadena de texto");
string cad1 = Console.ReadLine();
System.Console.WriteLine("La longitud de la cadena es de " + cad1.Length + " caracteres");

System.Console.WriteLine("Ingrese ota cadena de texto");
string cad2 = Console.ReadLine();
string cadConcat = $"{cad1}{cad2}";
System.Console.WriteLine(cadConcat);

Console.Write("Desde qué posición quiere extraer: ");
int inicio = int.Parse(Console.ReadLine());

Console.Write("Cuántos caracteres quiere extraer: ");
int cantidad = int.Parse(Console.ReadLine());

string subcadena = cad1.Substring(inicio, cantidad);

Console.WriteLine("Subcadena extraída: " + subcadena);