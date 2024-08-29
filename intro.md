# Introducción

## Template básico

```c#
namespace ejemplo
    internal class Program
    {
        // Main() es el punto de entrada del programa
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!!")
        }
    }
```
- `static` indica que el método `Main` se puede acceder desde de la clase y no desde el objeto. Está ligado a la clase.
- `void` indica que `Main` es un método no tiene valor de **retorno**.
- `string[] args` indica que el método `Main()` toma como argumento un arreglo de strings. Permite el ingreso de argumentos a `Main()`, por consola, al momento de ejecutar el programa.

## Tipos de datos

| Palabra clave | Intervalo                                                                                         | Valor por defecto |
|---------------|---------------------------------------------------------------------------------------------------|-------------------|
| `int`         | De -2.147.483.648 a 2.147.483.647                                                                  | `0`               |
| `float`       | De aproximadamente ±1.5 × 10^−45 a ±3.4 × 10^38 (con precisión de 7 dígitos significativos)        | `0.0f`            |
| `decimal`     | De ±1.0 × 10^−28 a ±7.9 × 10^28 (con precisión de 28-29 dígitos significativos)                    | `0.0m`            |
| `double`      | De aproximadamente ±5.0 × 10^−324 a ±1.7 × 10^308 (con precisión de 15-16 dígitos significativos)  | `0.0d`            |
| `string`      | No tiene un límite fijo, depende del entorno. Puede contener cualquier secuencia de caracteres.    | `null`            |
| `char`        | Cualquier carácter Unicode (UTF-16)                                                                | `'\0'`            |
| `bool`        | `true` o `false`                                                                                   | `false`           |

## Arreglos

| Tipo de Dato | Ejemplo de Declaración                             | Alternativa de Inicialización                                | Descripción                                          |
|--------------|----------------------------------------------------|--------------------------------------------------------------|------------------------------------------------------|
| `int`        | `int[] arr = new int[5];`                          | `int[] nums = { 1, 2, 3, 4, 5 };`                            | Arreglo de enteros.                                  |
| `string`     | `string[] arr = new string[5];`                    | `string[] autos = { "Volvo", "Fiat", "BMW" };`               | Arreglo de cadenas de texto.                         |
| `double`     | `double[] arr = new double[5];`                    | `double[] precios = { 1.99, 2.99, 3.99 };`                   | Arreglo de números de punto flotante de doble precisión. |
| `char`       | `char[] arr = new char[5];`                        | `char[] vocales = { 'a', 'e', 'i', 'o', 'u' };`              | Arreglo de caracteres.                               |
| `bool`       | `bool[] arr = new bool[5];`                        | `bool[] respuestas = { true, false, true };`                 | Arreglo de valores booleanos (`true` o `false`).     |
| `float`      | `float[] arr = new float[5];`                      | `float[] medidas = { 1.1f, 2.2f, 3.3f };`                    | Arreglo de números de punto flotante de precisión simple. |
| `decimal`    | `decimal[] arr = new decimal[5];`                  | `decimal[] montos = { 100.50m, 200.75m, 300.25m };`          | Arreglo de números decimales de alta precisión.     |
| `object`     | `object[] arr = new object[5];`                    | `object[] mezcla = { 1, "texto", 3.14 };`                    | Arreglo de objetos, que pueden ser de cualquier tipo. |


- En los arreglos debemos indicar el tipo y el tamaño.
- Son inmutables
- Se puede acceder a los valores usando la notación de corchete []

## Métodos de entrada y salida por consola

| Método               | Argumentos                          | Efecto                                                       |
|----------------------|-------------------------------------|--------------------------------------------------------------|
| `Console.WriteLine`  | `(string value)`                    | Escribe la cadena de texto seguida de un salto de línea.      |
|                      | `(object value)`                    | Convierte el objeto a su representación en cadena <br> y lo escribe seguido de un salto de línea. |
|                      | `(format, args)`                    | Escribe una cadena de texto formateada <br> seguida de un salto de línea. |
| `Console.Write`      | `(string value)`                    | Escribe la cadena de texto sin agregar un salto de línea.     |
|                      | `(object value)`                    | Convierte el objeto a su representación en cadena <br> y lo escribe sin salto de línea. |
|                      | `(format, args)`                    | Escribe una cadena de texto formateada <br> sin agregar un salto de línea. |
| `Console.ReadLine`       | `()`                                | Lee el siguiente carácter de la entrada estándar <br> sin mostrarlo. Devuelve el código entero del carácter. |

- `(string value)` es una cadena de caracteres.
- `(object value)` es cualquier tipo de dato en `C#`
- `(format, args)` es un formato de cadena de caracteres interpolados `$"{args1}, texto {args2}"`

