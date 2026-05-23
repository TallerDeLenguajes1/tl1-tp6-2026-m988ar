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
}*/
int indice = 0;
string menu;
float num2 = 0;
do
{
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1)Valor Absoluto");
    Console.WriteLine("2)Cuadrado");
    Console.WriteLine("3)Raiz cuadrada");
    Console.WriteLine("4)Seno");
    Console.WriteLine("5)Coseno");
    Console.WriteLine("6)Parte entera");
    Console.WriteLine("7)Sumar");
    Console.WriteLine("8)Restar");
    Console.WriteLine("9)Multiplicar");
    Console.WriteLine("10)Dividir");
    menu = Console.ReadLine();
    if (int.TryParse(menu, out indice) && indice < 11 && indice > 0)
    {
        Console.WriteLine("Ingrese el numero");

        if (!float.TryParse(Console.ReadLine(), out float num1))
        {
            System.Console.WriteLine("Ingrese un valor valido");
        }
        else if (indice > 6 && !float.TryParse(Console.ReadLine(), out num2))
        {
            System.Console.WriteLine("Ingrese un valor valido");
        }
        else
        {
            float resultado = 0;
            switch (indice)
            {
                case 1:
                    if (num1 > 0)
                    {
                        resultado = num1;
                    }
                    else
                    {
                        resultado = -1 * num1;
                    }
                    break;
                case 2:
                    resultado = num1 * num1;
                    break;
                case 3:
                    if (num1 >= 0)
                    {
                        resultado = (float)Math.Sqrt(num1);
                    }
                    else
                    {
                        Console.WriteLine("No existe raiz real");
                        continue;
                    }
                    break;
                case 4:
                    resultado = (float)Math.Sin(num1 * Math.PI / 180);
                    break;
                case 5:
                    resultado = (float)Math.Cos(num1 * Math.PI / 180);
                    break;
                case 6:
                    resultado = (int)num1;
                    break;
                case 7:
                    resultado = num1 + num2;
                    break;
                case 8:
                    resultado = num1 - num2;
                    break;
                case 9:
                    resultado = num1 * num2;
                    break;
                case 10:
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
        System.Console.WriteLine("Elija dos numeros para saber cual es el minimo y maximo");
        if (!float.TryParse(Console.ReadLine(), out float num3))
        {
            System.Console.WriteLine("Ingrese un valor valido");
        }
        if (!float.TryParse(Console.ReadLine(), out float num4))
        {
            System.Console.WriteLine("Ingrese un valor valido");
        }
        if (num3 > num4)
        {
            System.Console.WriteLine("Mayor:" + num3 + "\nMenor: " + num4);
        }
        else if (num3 < num4)
        {
            System.Console.WriteLine("Mayor:" + num4 + "\nMenor: " + num3);
        }
        else
        {
            System.Console.WriteLine("Son iguales");
        }
    }
    else
    {
        Console.WriteLine("Elija una opcion valida");
    }
    Console.WriteLine("Desea realizar otro calculo? \n1)Si\n0)No");
    menu = Console.ReadLine();
}while (int.TryParse(menu, out indice) && indice == 1);
