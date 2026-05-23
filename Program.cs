Console.WriteLine("Hello, World!");
/*
//Ejercicio 1
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
}*/

//Ejercicio 2

int indice = 0;
string menu;

do
{
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1)Sumar");
    Console.WriteLine("2)Restar");
    Console.WriteLine("3)Multiplicar");
    Console.WriteLine("4)Dividir");
    menu = Console.ReadLine();
    if (int.TryParse(menu, out indice) && indice < 5 && indice > 0)
    {
        Console.WriteLine("Ingrese el 1er numero");

        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            continue;
        }

        Console.WriteLine("Ingrese el 2do numero");

        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            continue;
        }

        int resultado = 0;
        switch (indice)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;    
                }
                else
                {
                    Console.WriteLine("SyntaxError");
                }
                break;
        }
        Console.WriteLine("Resultado: " + resultado);
    }
    else
    {
        Console.WriteLine("Elija una opcion valida");
    }
    Console.WriteLine("Desea realizar otro calculo? \n1)Si\n0)No");
    menu = Console.ReadLine();
} while (int.TryParse(menu, out indice) && indice < 5 && indice > 0);
