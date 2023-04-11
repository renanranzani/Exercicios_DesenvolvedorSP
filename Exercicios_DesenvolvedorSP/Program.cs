using Exercicios_DesenvolvedorSP.Factory;
using Exercicios_DesenvolvedorSP.Interfaces;


Console.WriteLine("Qual item você gostaria de visualizar?\n" +
    "1 - Faturamento Diários\n" +
    "2 - Checar númnero Fibonacci\n" +
    "3 - Percentual de faturamento nos estados\n" +
    "4 - Inverter os caracteres\n");

Console.WriteLine("\nDigite o número desejado:");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:
        IFaturamentoDiario faturamento = new FaturamentoDiario();
        faturamento.CalculoFaturamento();
        break;

    case 2:
        IFibonacci fibonacci = new Fibonacci();
        fibonacci.CalculoFibonacci();
        break;

    case 3:
        IPercentualFaturamentoEstados percentualFaturamentoEstados = new PercentualFaturamentoEstados();
        percentualFaturamentoEstados.CalculoDePercentual();
        break;

    case 4:
        IInversaoCaracteres inversaoCaracteres = new InversaoCaracteres();
        inversaoCaracteres.InversaoDeCaracteres();
        break;
}