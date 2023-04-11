using Exercicios_DesenvolvedorSP.Interfaces;

namespace Exercicios_DesenvolvedorSP.Factory
{
    internal class Fibonacci : IFibonacci
    {
        public void CalculoFibonacci()
        {
            Console.WriteLine("Insira um número para verificação de existência na sequência Fibonacci:\n");
            int numero = int.Parse(Console.ReadLine());

            int[] fibonacci = { 0, 1 };

            while (fibonacci[fibonacci.Length - 1] < numero)
            {
                int novoNumero = fibonacci[fibonacci.Length - 1] + fibonacci[fibonacci.Length - 2];
                Array.Resize(ref fibonacci, fibonacci.Length + 1);
                fibonacci[fibonacci.Length - 1] = novoNumero;
            }

            if (Array.IndexOf(fibonacci, numero) != -1)
            {
                Console.WriteLine(numero + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine(numero + " não pertence à sequência de Fibonacci.");
            }
        }
    }
}
