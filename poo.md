# Programación Orientada a Objetos

- Intenta modelar objetos de la vida real
- Es una manera de construir software
- Podemos modelar entidades tangibles o intangibles
- Podemos compartir responsabilidades

## Elementos

Una **clase** es una plantilla por la cual instanciamos a los **objetos**.

Los elementos básicos de las **clases** u **objetos** son:

- Atributos $\rightarrow$ Características
- Métodos $\rightarrow$ Comportamientos

__Ejemplo__: Pensemos una silla

Atributos: modelo, color, material, garantía, código, precio


## Ejemplo en `C#`

### Modificadores de acceso

ver:

- private
- internal
- public

TODAS LAS CLASES SON HIJAS DE UNA CLASE `Object`

```c#
namespace Consola
{
    internal class Silla
    {
        static void Main(string[] args)
        {
            //Declarar atributos (el guión bajo y minúscula es una convención
            //ATRIBUTOS: Siempre privados
            private string _modelo;
            private string _color;
            private string _material;
            private int _codigo;
            private double _precio;
            private bool _tieneGarantia;

            // DECLARACIÓN DE CONSTRUCTOR
            public Silla(string modelo, string color, string material, int codigo, double precio, bool tieneGarantia)
            {
            
                _modelo = modelo;
                _color = color;
                _material = material;
                _codigo = codigo;
                _precio = precio;
                _tienePrecio = tienePrecio
            }

            // CONSTRUCTOR VACÍO: Lo tengo que escribir si lo necesito
            // En caso de no declarar el constructor anterior, no es necesario escribir este
            public Silla()
            {

            }

            // PROPERTIES: Nos permite obtener y modificar los atributos
            // Puedo tener el get, o el set o los dos
            public string Modelo
            {
                get
                {
                    return _modelo
                }
                set
                {
                    _modelo = value;
                }
            }

            // Constructor con un valor por defecto de tieneGarantia
            public Silla(string modelo, string color, string material, int codigo, double, precio){
                _modelo = modelo;
                _color = color;
                _material = material;
                _codigo = codigo;
                _precio = precio;
                _tienePrecio = false;
            }

            // Métodos que determinan el comportamiento de mis objetos
            public string AlgunosDatos()
            {
                return $"Id: {_codigo} - Modelo: {_modelo} - Precio: ${_precio}"
            }

            public string double CalcularPrecioFinal()
            {
                double precioFinal = _precio;
                if(_tieneGarantia) precioFinal += 200;
                return precioFinal;
            }

            // Sobreescribir el método ToString
            public override string ToString()
            {
                return $"Id: {_codigo} - Modelo: {_modelo} - Precio base: ${_precio} - Precio final: ${CalcularPrecioFinal()} - Garantia: {_tieneGarantia}"
            }

            // VALIDAR OBJETOS
            public bool Validar()
            {
                return !string.IsNullOrEmpty(_modelo) && !string_isNullOrEmpty(_color)...;
            }
        }

    }
}
```

Invocar el objeto silla

```c#
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Silla miSilla1 = new Silla("Silla de comedor", "Marrón", "Pino", 1500, false);
            Silla miSilla2 = new Silla("Silla de playa", "Blanco", "Plástico", 2, 500);

            // Esto no podré hacerlo porque _modelo es un atributo privado
            Console.WriteLine(miSilla._modelo);

            // Obtener atributo
            string modeloDeSilla1 = miSilla1.Modelo;
            Console.ReadLine(modeloDeSilla1);
            // Modificar atributo
            miSilla1.Modelo = "Sillón de living";

            Console.WriteLine(miSilla1.AlgunosDatos());

            Console.WriteLine(miSilla1): // Muestra la ruta de la clase 
        }
    }
}

```

**Firma de un objeto**:
- Tipo de dato de retorno
- Tipo de datos 
- Nombre de la objeto

**Sobre carga**
Cuando tengo más de una versión de un método, donde cambian los parámetros.
Por ejemplo en la sobrecarga del método constructor.

