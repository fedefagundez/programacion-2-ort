namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Federico Fagúndez", "CC", "$", "123456");
            Cuenta cuenta2 = new Cuenta("Nahuel Delfino", "CA", "$", "123456789");
            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}
