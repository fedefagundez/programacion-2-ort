# Objeto `DateTime`
## **¿Que es `DateTime`?**

- `DateTime` es una estructura en el espacio de nombres `System` que representa una fecha y una hora en el calendario gregoriano. Esta estructura permite realizar una variedad de operaciones relacionadas con la fecha y la hora, como comparación, cálculo de intervalos y formateo.

## **Tipos**

1. `DateTime.Now`: Obtiene la fecha y hora actuales según el reloj del sistema.
2. `DateTime.UtcNow`: Obtiene la fecha y hora actuales en formato UTC (Tiempo Universal Coordinado).
3. `DateTime.Today`: Obtiene la fecha actual con la hora establecida en medianoche.
4. `DateTime.MinValue`: Representa la fecha mínima que puede ser representada por `DateTime` (1 de enero de 0001 a las 00:00:00).
5. `DateTime.MaxValue`: Representa la fecha máxima que puede ser representada por `DateTime` (31 de diciembre de 9999 a las 23:59:59.9999999).

## **Constructor**

- Puedes crear una instancia de `DateTime` de varias maneras:

```c#
    DateTime fecha1 = new DateTime(2024, 9, 7); //Año, Mes, Día

    DateTime fecha2 = new DateTime(2024, 9, 7, 15, 30, 0); //Año, Mes, Día, Hora,Minuto, Segundo
    DateTime fecha3 = DateTime.Now; //Fecha y hora actuales
```

## **Métodos**

- **`AddDays(double value)`**: Devuelve una nueva instancia de `DateTime` que representa la fecha y hora resultantes de sumar el número especificado de días. Podemos sumar fracciones de día.

    **Ejemplo**:  
  ```c#
  DateTime hoy = DateTime.Now;
  DateTime futuro = hoy.AddDays(5);
  Console.WriteLine(futuro);  // Muestra la fecha y hora 5 días después de la actual.
  ```

- `AddMonths(int months)`: Devuelve una nueva instancia de `DateTime` que representa la fecha y hora resultantes de sumar el número especificado de meses. 

    **Ejemplo**
    ```c#
    DateTime hoy = DateTime.Now;
    DateTime futuro = hoy.AddMonths(2);
    Console.WriteLine(futuro);  // Muestra la fecha y hora 2 meses después de la actual.
    ```

- `ToString(string format)`: Devuelve una representación de cadena de la fecha y hora actual, usando el formato especificado.

    **Ejemplo**
    ```c#
    DateTime hoy = DateTime.Now;
    string formatoPersonalizado = hoy.ToString("yyyy-MM-dd");
    Console.WriteLine(formatoPersonalizado);  // Muestra la fecha en el formato 'año-mes-día'.

    ```

- `Subtract(DateTime value)`: Calcula la diferencia entre dos instancias de `DateTime` y devuelve un objeto TimeSpan.

    **Ejemplo**
    ```c#
    DateTime fecha1 = new DateTime(2024, 9, 8);
    DateTime fecha2 = new DateTime(2024, 9, 1);
    TimeSpan diferencia = fecha1.Subtract(fecha2);
    Console.WriteLine(diferencia.Days);  // Muestra la diferencia de 7 días.
    ```

## **Formatos de fecha y hora**

- `DateTime` proporciona varios formatos para representar fechas y horas. Puedes usar los formatos estándar (como `"d"`, `"D"`, `"t"`, `"T"`, `"f"`, `"F"`, `"g"`, `"G"`, `"M"`, `"O"`, `"R"`, `"s"`, `"u"`, `"U"`, `"Y"`) y también puedes crear formatos personalizados usando cadenas como `"yyyy-MM-dd"`, `"MM/dd/yyyy"`, etc.
- Ejemplo:

```c#
DateTime ahora = DateTime.Now;
string formatoCorto = ahora.ToString("d"); // Formato corto de fecha
string formatoCompleto = ahora.ToString("F"); // Formato completo de fecha y hora
```

## **Comparación y cálculo**

- Puedes comparar fechas y horas usando los operadores estándar (>, <, ==, etc.) y también usando métodos como `CompareTo` o `Equals`. Para calcular la diferencia entre dos fechas, puedes usar el método `Subtract` para obtener un objeto `TimeSpan`.

- Ejemplo:

```c#
DateTime fecha1 = new DateTime(2024, 1, 1);
DateTime fecha2 = new DateTime(2024, 12, 31);
TimeSpan diferencia = fecha2 - fecha1; // Obtiene la diferencia en días
```

## **Zona Horaria**

 - `DateTime` no maneja directamente las zonas horarias. Para trabajar con zonas horarias, puedes usar `DateTimeOffset`, que incluye la información de la diferencia de tiempo respecto a UTC.

## **Ejemplo completo**

```c#
using System;

class Program
{
    static void Main()
    {
        DateTime ahora = DateTime.Now;
        Console.WriteLine("Fecha y hora actuales: " + ahora);

        DateTime fechaFutura = ahora.AddDays(10);
        Console.WriteLine("Fecha dentro de 10 días: " + fechaFutura.ToString("yyyy-MM-dd"));

        TimeSpan diferencia = fechaFutura - ahora;
        Console.WriteLine("Días de diferencia: " + diferencia.Days);
    }
}
```


 

