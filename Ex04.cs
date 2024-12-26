using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = pi * Math.Pow(raio, 2);
            Console.WriteLine("A=" + resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}