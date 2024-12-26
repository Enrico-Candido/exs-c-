using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');

            float valorA = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float valorB = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float valorC = float.Parse(vet[2], CultureInfo.InvariantCulture);
            float pi = 3.14159F;

            float triangulo = valorA * valorC / 2;
            double circulo = pi * Math.Pow(valorC, 2);
            float trapezio = (valorA + valorB) * valorC / 2;
            float quadrado = valorB * valorB;
            float retantuglo = valorA * valorB;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retantuglo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}