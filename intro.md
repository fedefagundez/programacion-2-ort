# Introducción a `C#`

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
| `int`         | De $-2.147.483.648$ a $2.147.483.647$                                                                  | `0`               |
| `float`       | De aproximadamente $±1.5 × 10^{−45}$ a $±3.4 × 10^{38}$ (con precisión de 7 dígitos significativos)        | `0.0f`            |
| `decimal`     | De $±1.0 × 10^{−28}$ a $±7.9 × 10^{28}$ (con precisión de 28-29 dígitos significativos)                    | `0.0m`            |
| `double`      | De aproximadamente $±5.0 × 10^{−324}$ a $±1.7 × 10^{308}$ (con precisión de 15-16 dígitos significativos)  | `0.0d`            |
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

| **Método**            | **Argumentos**                      | **Efecto**                                                   | **Ejemplo**                                                  |
|-----------------------|-------------------------------------|--------------------------------------------------------------|--------------------------------------------------------------|
| **`Console.WriteLine`** | `string value`                      | - Escribe la cadena de texto seguida de un salto de línea.    | `Console.WriteLine("Hola Mundo");`                           |
|                       | `object value`                      | - Convierte el objeto a su representación en cadena <br> y lo escribe seguido de un salto de línea. | `Console.WriteLine(objeto);`                                 |
|                       | `string interpolation`               | - Escribe una cadena de texto interpolada <br> seguida de un salto de línea. | `Console.WriteLine($"El valor es {valor}");`                 |
| **`Console.Write`**    | `string value`                      | - Escribe la cadena de texto sin agregar un salto de línea.   | `Console.Write("Hola");`                                     |
|                       | `object value`                      | - Convierte el objeto a su representación en cadena <br> y lo escribe sin salto de línea. | `Console.Write(objeto);`                                     |
|                       | `string interpolation`               | - Escribe una cadena de texto interpolada <br> sin agregar un salto de línea. | `Console.Write($"El valor es {valor}");`                     |
| **`Console.ReadLine`** | `n/a`                               | - Lee la siguiente línea de la entrada estándar y la devuelve como una cadena de texto. | `string entrada = Console.ReadLine();`                       |

## Estructuras de control

### **`if`**

```c#
if (condición) 
{
    // código si condición es verdadera
}
```

### **`else if`**  

```c# 
if (condición1) 
{
    // código si condición1 es verdadera
} 
else if (condición2) 
{
    // código si condición2 es verdadera
}
```

### **`else`**  

```c#
if (condición1)
{
    // código si condición1 es verdadera
} 
else if (condición2) 
{
    // código si condición2 es verdadera
} 
else 
{
    // código si todas las condiciones anteriores son falsas
}
```

### **`switch`**  

```c# 
switch (variable) 
{
    case valor1:
        // código
        break;
    case valor2:
        // código
        break;
    default:
        // código
        break;
}
```
### **`try-catch`**  

```c# 
try 
{
    // código que puede causar una excepción
} 
catch (Exception ex) 
{
    // manejo de la excepción
} 
finally 
{
    // código que siempre se ejecuta
}
```

- Maneja excepciones para evitar que errores detengan el programa.
- El bloque `catch` captura y maneja los errores (excepciones).
- Puedes usar múltiples bloques `catch` para manejar diferentes tipos de excepciones.
- El bloque `finally` (opcional) se ejecuta siempre, haya o no excepción.

## Métodos de conversión 

### Métodos `Parse`

1. **`int.Parse(string)`**
    - Convierte un `string` en un `int`
    - Ejemplo: `int num = int.Parse("123")`

2. **`double.Parse(string)`**
    - Convierte un `string` en un `double`
    - Ejemplo: `double num = double.Parse("123.45")`

3. **`long.Parse(string)`**
    - Convierte un `string` en un `long`
    - Ejemplo: `long num = long.Parse("12345678")`

4. **`decimal.Parse(string)`**
    - Convierte un `string` en un `decimal`
    - Ejemplo: `decimal num = decimal.Parse("123.45")`

### Métodos `TryParse`
 
1. **`int.TryParse(string, out int result)`**
   - Intenta convertir un `string` en un `int`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (int.TryParse("123", out int num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
2. **`double.TryParse(string, out double result)`**
   - Intenta convertir un `string` en un `double`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (double.TryParse("123.45", out double num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
3. **`long.TryParse(string, out long result)`**
   - Intenta convertir un `string` en un `long`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (long.TryParse("12345678", out long num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
4. **`decimal.TryParse(string, out decimal result)`**
   - Intenta convertir un `string` en un `decimal`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (decimal.TryParse("123.45", out decimal num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```

### Convertir a otros tipos numéricos
 
1. **`float.TryParse(string, out float result)`**
   - Intenta convertir un `string` en un `float`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (float.TryParse("123.45", out float num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
2. **`byte.TryParse(string, out byte result)`**
   - Intenta convertir un `string` en un `byte`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (byte.TryParse("255", out byte num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
3. **`sbyte.TryParse(string, out sbyte result)`**
   - Intenta convertir un `string` en un `sbyte`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (sbyte.TryParse("127", out sbyte num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
4. **`short.TryParse(string, out short result)`**
   - Intenta convertir un `string` en un `short`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (short.TryParse("12345", out short num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
5. **`ushort.TryParse(string, out ushort result)`**
   - Intenta convertir un `string` en un `ushort`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (ushort.TryParse("12345", out ushort num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
6. **`uint.TryParse(string, out uint result)`**
   - Intenta convertir un `string` en un `uint`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (uint.TryParse("12345", out uint num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```
 
7. **`ulong.TryParse(string, out ulong result)`**
   - Intenta convertir un `string` en un `ulong`. Devuelve `true` si la conversión es exitosa; de lo contrario, devuelve `false`.
   - Ejemplo:
     ```csharp
     if (ulong.TryParse("123456789", out ulong num)) {
         // Conversion exitosa, usar num
     } else {
         // Manejar el error de conversión
     }
     ```



 

