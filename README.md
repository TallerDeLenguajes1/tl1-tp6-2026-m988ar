# TP 6 Borja Luca Valentin

## ¿String es una tipo por valor o un tipo por referencia?

 En C#, string es un tipo por referencia.

 Sin embargo, tiene un comportamiento especial llamado inmutabilidad, lo que significa que una vez creada una cadena, su contenido no puede modificarse.

## ¿Qué secuencias de escape tiene el tipo string?

    Las secuencias de escape son caracteres especiales que comienzan con \ y permiten representar saltos de línea, comillas, tabulaciones, entre otros.
    | Secuencia | Significado |
    |------------|----------------------|
    | `\n` | Salto de línea |
    | `\t` | Tabulación |
    | `\\` | Barra invertida `\` |
    | `\"` | Comillas dobles |
    | `\'` | Comilla simple |
    | `\r` | Retorno de carro |
    | `\0` | Carácter nulo |

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

    El carácter @ crea una cadena literal, permitiendo escribir el texto exactamente como aparece, sin interpretar secuencias de escape.

    El carácter $ permite usar interpolación de cadenas, es decir, insertar variables o expresiones dentro del texto usando {}.

    También pueden combinarse permitiendo usar interpolación y cadenas literales al mismo tiempo.