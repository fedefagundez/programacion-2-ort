namespace Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                CrearMenu();
                opcion = Console.ReadLine();
                Console.Clear();
                switch(opcion)
                {
                    case "1":
                        Ejercicio1();
                        break;
                    case "2":
                        Ejercicio2();
                        break;
                    case "3":
                        Ejercicio3();
                        break;
                    case "4":
                        Ejercicio4();
                        break;
                    case "5":
                        Ejercicio5();
                        break;
                    case "6":
                        Ejercicio6();
                        break;
                    case "7":
                        Ejercicio7();
                        break;
                    case "8":
                        Ejercicio8();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo ...");
                        break;
                    default:
                        EscribirMensajeConColor(ConsoleColor.Red, "Opcion incorrecta");
                        break;
                }
            }
            while (opcion != "0");

        }

        #region METODOS AUXILIARES

        static void EscribirMensajeConColor(ConsoleColor color, string mensaje)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Crear menu
        static void CrearMenu()
        {
            Console.Clear();
            EscribirMensajeConColor(ConsoleColor.Yellow, "##################################################");
            EscribirMensajeConColor(ConsoleColor.Yellow, "#                    Menú                        #");
            EscribirMensajeConColor(ConsoleColor.Yellow, "##################################################");
            Console.WriteLine();
            EscribirMensajeConColor(ConsoleColor.Gray, "               1. Ejercicio 1");
            EscribirMensajeConColor(ConsoleColor.Gray, "               2. Ejercicio 2");
            EscribirMensajeConColor(ConsoleColor.Gray, "               3. Ejercicio 3");
            EscribirMensajeConColor(ConsoleColor.Gray, "               4. Ejercicio 4");
            EscribirMensajeConColor(ConsoleColor.Gray, "               5. Ejercicio 5");
            EscribirMensajeConColor(ConsoleColor.Gray, "               6. Ejercicio 6");
            EscribirMensajeConColor(ConsoleColor.Gray, "               7. Ejercicio 7");
            EscribirMensajeConColor(ConsoleColor.Gray, "               8. Ejercicio 8");
            EscribirMensajeConColor(ConsoleColor.Gray, "               0. Salir");
            Console.WriteLine();
            Console.Write("Elija una opción: ");
        }

        static void CrearEncabezado(string numeroDeEjercicio)
        {
            EscribirMensajeConColor(ConsoleColor.Yellow, "#################################");
            EscribirMensajeConColor(ConsoleColor.Yellow, $"#        Ejercicio N°{numeroDeEjercicio}          #");
            EscribirMensajeConColor(ConsoleColor.Yellow, "#################################");
            Console.WriteLine();
        }

        static int SolicitarNumero(string mensaje)
        {
            int numero;
            bool exito = false;
            do
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);

                if (!exito) MostrarError("Error: debe ingresar solo números.");

            } while (!exito);

            return numero;

        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void PressToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static string SolicitarPalabra(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

        #endregion

        #region EJERCICIOS
        static void Ejercicio1()
        {
            CrearEncabezado("1");
            int numero = SolicitarNumero("Escriba un número entre el 1 y el 10: ");

            Random rnd = new Random();
            int numeroRandom = rnd.Next(11);

            if (numero == numeroRandom)
            {
                EscribirMensajeConColor(ConsoleColor.Blue, "El número es igual al número random.");
            }
            else
            {
                EscribirMensajeConColor(ConsoleColor.Blue, "El número no es igual al número random.");
            }
            PressToContinue();
        }

        static void Ejercicio2()
        {
            CrearEncabezado("2");
            int numero = SolicitarNumero("Ingrese un número del 1 al 10: ");
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
            PressToContinue();
        }

        static void Ejercicio3()
        {
            CrearEncabezado("3");
            int numero1 = SolicitarNumero("Ingrese el primer número: ");
            int numero2 = SolicitarNumero("Ingrese el segundo número: ");

            if (numero2 < numero1)
            {
                int auxiliar = numero1;
                numero1 = numero2;
                numero2 = auxiliar;
            }

            for (int i = numero1; i <= numero2; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
            PressToContinue();
        }
        
        static void Ejercicio4()
        {
            CrearEncabezado("4");
            int numero1 = SolicitarNumero("Ingrese el primer número: ");
            int numero2 = SolicitarNumero("Ingrese el segundo número: ");
            int valor = SolicitarNumero("Ingrese un valor: ");
            if (numero2 < numero1)
            {
                int auxiliar = numero1;
                numero1 = numero2;
                numero2 = auxiliar;
            }
            if (valor >= numero1 && valor <= numero2)
            {
                EscribirMensajeConColor(ConsoleColor.Blue, $"El valor se encuentra entre {numero1} y {numero2}.");
            } 
            else
            {
                EscribirMensajeConColor(ConsoleColor.Blue, $"El valor no se encuentra entre {numero1} y {numero2}.");
            }
            PressToContinue();
        }

        static void Ejercicio5()
        {
            CrearEncabezado("5");
            Console.WriteLine("Deberá ingresar númoros que se irán sumando.");
            Console.WriteLine("Para finalizar presione 0...");
            int numero;
            int suma = 0;
            do
            {
                numero = SolicitarNumero("Ingrese un número: ");
                suma += numero;
            } while (numero != 0);

            Console.WriteLine();
            EscribirMensajeConColor(ConsoleColor.Blue, $"El resultado de la suma es: {suma}");

            PressToContinue();
        }

        static void Ejercicio6()
        {
            string palabra = SolicitarPalabra("Ingrese una palabra: ");
            string vocales = "aeiouáéíóú";
            int contador = 0;
            for (int i = 0; i < palabra.Length; i++ )
            {
                if (vocales.Contains(char.ToLower(palabra[i]))) contador++;
            }
            EscribirMensajeConColor(ConsoleColor.Blue, $"La palabra contiene {contador} vocales");
            PressToContinue();
        }

        static void Ejercicio7()
        {
            CrearEncabezado("7");
            string palabra = SolicitarPalabra("Ingrese una palabra: ");
            EscribirMensajeConColor(ConsoleColor.Blue, $"Palabra: {palabra}");
            EscribirMensajeConColor(ConsoleColor.Blue, $"Palabra invertida: {InvertirPalabra(palabra)}");
            PressToContinue();
        }

        static void Ejercicio8()
        {
            CrearEncabezado("8");
            string palabra = SolicitarPalabra("Ingrese una palabra: ");
            if(palabra.ToLower() == InvertirPalabra(palabra).ToLower())
            {
                EscribirMensajeConColor(ConsoleColor.Blue, $"\"{palabra}\" es un palíndromo.");
            }
            else
            {
                EscribirMensajeConColor(ConsoleColor.Blue, $"\"{palabra}\" no es un palíndromo.");
            }
            PressToContinue();
        }

        static string InvertirPalabra(string palabra)
        {
            string palabraInertida = "";
            for(int i = 0; i < palabra.Length; i++)
            {
                palabraInertida = palabra[i] + palabraInertida;
            }
            return palabraInertida;
        }
        #endregion



    }
}
