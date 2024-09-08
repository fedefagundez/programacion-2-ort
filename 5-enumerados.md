# **Enumerados**

## **Definición**

- Un `enum` se define usando la palabra clave `enum`, seguida del nombre del enumerado y una lista de constantes. Por defecto, el tipo subyacente de un `enum` es `int`, pero puedes especificar un tipo diferente si es necesario.
- Los `enum` son una forma poderosa y legible para manejar conjuntos fijos de valores en `C#`. Permiten escribir código más claro y fácil de mantener, evitando el uso de números mágicos o cadenas de texto para representar estados o opciones.

```c#
enum DiaDeLaSemana
{
    Lunes,
    Martes,
    Miércoles,
    Jueves,
    Viernes,
    Sábado,
    Domingo
}
```

## **Valores subyacentes**

- Por defecto, el primer miembro del `enum` tiene el valor 0 y cada miembro subsiguiente incrementa su valor en 1. Puedes especificar los valores explícitamente si lo deseas.

```c#
enum Estado
{
    Inactivo = 0,
    Activo = 1,
    Pendiente = 2,
    Suspendido = 3
}

```

## **Tipo Subyacente**

- Puedes especificar un tipo subyacente para el `enum`. Los tipos permitidos son los tipos enteros de tamaño pequeño: `byte`, `sbyte`, `short`, `ushort`, `int` y `uint`.

```c#
enum Meses : byte
{
    Enero = 1,
    Febrero = 2,
    Marzo = 3,
    Abril = 4,
    Mayo = 5,
    Junio = 6,
    Julio = 7,
    Agosto = 8,
    Septiembre = 9,
    Octubre = 10,
    Noviembre = 11,
    Diciembre = 12
}
```

## **Uso de un `enum`**

- Para usar un `enum`, puedes asignar valores a variables y compararlas. También puedes convertir entre el tipo `enum` y su tipo subyacente.

```c#
class Program
{
    static void Main()
    {
        DiaDeLaSemana hoy = DiaDeLaSemana.Viernes;

        Console.WriteLine($"Hoy es: {hoy}"); // Imprime: Hoy es: Viernes

        // Convertir a entero
        int valor = (int)hoy;
        Console.WriteLine($"Valor entero: {valor}"); // Imprime: Valor entero: 4

        // Convertir de entero a enum
        DiaDeLaSemana dia = (DiaDeLaSemana)4;
        Console.WriteLine($"Día correspondiente al valor 4: {dia}"); // Imprime: Día correspondiente al valor 4: Viernes

        // Verificar si un valor es válido en el enum
        if (Enum.IsDefined(typeof(DiaDeLaSemana), 4))
        {
            Console.WriteLine("El valor 4 es un miembro definido del enum DiaDeLaSemana.");
        }
    }
}
```
## **Métodos**

- `Enum.GetValues(Type enumType)`: Devuelve una matriz de los valores del `enum`.

```c#
foreach (DiaDeLaSemana dia in Enum.GetValues(typeof(DiaDeLaSemana)))
{
    Console.WriteLine(dia);
}
```

- `Enum.GetNames(Type enumType)`: Devuelve una matriz de los nombres de los miembros del `enum`.

```c#
foreach (string nombre in Enum.GetNames(typeof(DiaDeLaSemana)))
{
    Console.WriteLine(nombre);
}
```

- `Enum.TryParse<TEnum>(string value, out TEnum result)`: Intenta convertir una cadena en una instancia del `enum`.

```c#
if (Enum.TryParse("Viernes", out DiaDeLaSemana dia))
{
    Console.WriteLine($"Conversión exitosa: {dia}");
}
else
{
    Console.WriteLine("Conversión fallida.");
}
```

## **Flags**

- Puedes usar el atributo `[Flags]` para definir un `enum` que actúe como un conjunto de bits, permitiendo la combinación de valores mediante operaciones bit a bit.

```c#
[Flags]
enum Permisos
{
    Ninguno = 0,
    Leer = 1,
    Escribir = 2,
    Ejecutar = 4,
    Administrar = Leer | Escribir | Ejecutar
}

class Program
{
    static void Main()
    {
        Permisos usuarioPermisos = Permisos.Leer | Permisos.Ejecutar;

        Console.WriteLine(usuarioPermisos.HasFlag(Permisos.Leer)); // Imprime: True
        Console.WriteLine(usuarioPermisos.HasFlag(Permisos.Administrar)); // Imprime: False
    }
}
```