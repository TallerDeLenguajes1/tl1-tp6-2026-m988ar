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
//Calculadora


int indice = 0;
string menu;
float num1 = 0 ,num2 = 0;
do
{
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1)Valor Absoluto");
    Console.WriteLine("2)Cuadrado");
    Console.WriteLine("3)Raiz cuadrada");
    Console.WriteLine("4)Seno");
    Console.WriteLine("5)Coseno");
    Console.WriteLine("6)Parte entera");
    Console.WriteLine("7)Operacion simplre(+,-,*,/)");

    menu = Console.ReadLine();
    if (int.TryParse(menu, out indice) && indice < 8 && indice > 0)
    {
        if (indice != 7)
        {
            System.Console.WriteLine("Elija un numero");
            if (!float.TryParse(Console.ReadLine(), out num1))
            {
                System.Console.WriteLine("Ingrese un valor valido");
            }
            if (indice > 6 && indice < 8)
            {
                System.Console.WriteLine("Ingrese un numero mas");
            }
            if (indice > 6 && !float.TryParse(Console.ReadLine(), out num2))
            {
                System.Console.WriteLine("Ingrese un valor valido");
            }
        }
        Console.WriteLine("Ingrese el numero");




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
                System.Console.WriteLine("El valor absoluto de " + num1 + " es "
                    + resultado);
                break;
            case 2:
                resultado = num1 * num1;
                System.Console.WriteLine("El cuadrado de " + num1 + " es "
                    + resultado);

                break;
            case 3:
                if (num1 >= 0)
                {
                    resultado = (float)Math.Sqrt(num1);
                    System.Console.WriteLine("La Raiz cuadrada de " + num1 + " es "
                    + resultado);
                }
                else
                {
                    Console.WriteLine("No existe raiz real");
                    continue;
                }
                break;
            case 4:
                resultado = (float)Math.Sin(num1 * Math.PI / 180);
                System.Console.WriteLine("El Seno de " + num1 + " es "
                    + resultado);
                break;
            case 5:
                resultado = (float)Math.Cos(num1 * Math.PI / 180);
                System.Console.WriteLine("El Coseno de " + num1 + " es "
                    + resultado);
                break;
            case 6:
                resultado = (int)num1;
                System.Console.WriteLine("La parte entera de " + num1 + " es "
                    + resultado);
                break;
            case 7:
                System.Console.WriteLine("Escriba la operacion que desea relizar solo entre dos numeros");
                string calculo = Console.ReadLine();
                string[] numeros;
                char operando = '`';
                for (int i = 0; i < calculo.Length; i++)
                {
                    if (calculo[i] == '+' || calculo[i] == '-' ||
                    calculo[i] == '*' || calculo[i] == '/')
                    {
                        operando = calculo[i];
                    }
                }
                numeros = calculo.Split(operando);
                if (float.TryParse(numeros[0], out num1) && float.TryParse(numeros[1], out num2))
                {
                    switch (operando)
                    {
                        case '+':
                            resultado = num1 + num2;
                            System.Console.WriteLine("La suma de " + num1 + " mas "
                                + num2 + " es igual a " + resultado);
                            break;
                        case '-':
                            resultado = num1 - num2;
                            System.Console.WriteLine("La resta de " + num1 + " menos "
                                + num2 + " es igual a " + resultado);
                            break;
                        case '*':
                            resultado = num1 * num2;
                            System.Console.WriteLine("La multiplicacion entre " + num1 + " y "
                                + num2 + " es igual a " + resultado);
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                                System.Console.WriteLine("La division entre " + num1 + " y "
                                + num2 + " es igual a " + resultado);
                            }
                            else
                            {
                                Console.WriteLine("SyntaxError");
                            }
                            break;

                    }

                }
                break;
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
} while (int.TryParse(menu, out indice) && indice == 1);


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

foreach (char caracter in cadConcat)
{
    System.Console.WriteLine(caracter);
}

System.Console.WriteLine("Cad1 en Mayusuclas: '" + cad1.ToUpper()+ "'");
System.Console.WriteLine("Cad1 en Minusculas: '" + cad1.ToLower()+"'");

System.Console.WriteLine("Escriba un texto a separar");
string separar = Console.ReadLine();
System.Console.WriteLine("Elija en que caracter quiere que se separa el texto");
char separador = (char)Console.Read();
string[] separado = separar.Split(separador);
foreach (string parteSeparada in separado)
{
    System.Console.WriteLine(parteSeparada);
}
