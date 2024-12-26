using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            string[] vet1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(vet1[0]);
            int numPecas1 = int.Parse(vet1[1]);
            float valorPeca1 = float.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(vet2[0]);
            int numPecas2= int.Parse(vet2[1]);
            float valorPeca2 = float.Parse(vet2[2], CultureInfo.InvariantCulture);

            float calculo = numPecas1 * valorPeca1 + numPecas2 * valorPeca2;
           
            Console.WriteLine("Código da peça: " + codigoPeca1);
            Console.WriteLine("Código da peça: " + codigoPeca2);
            Console.WriteLine("Valor a pagar: R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}