using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            float horasTrabalhadas = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER: " + numeroFuncionario);
            Console.WriteLine("SALARY: U$ " + (horasTrabalhadas * valorHora).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}