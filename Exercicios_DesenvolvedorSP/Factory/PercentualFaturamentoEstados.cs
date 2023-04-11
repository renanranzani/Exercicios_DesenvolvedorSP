using Exercicios_DesenvolvedorSP.Interfaces;

namespace Exercicios_DesenvolvedorSP.Factory
{
    internal class PercentualFaturamentoEstados : IPercentualFaturamentoEstados
    {
        public void CalculoDePercentual()
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            double faturamentoTotal = sp + rj + mg + es + outros;

            double pctSp = sp / faturamentoTotal * 100;
            double pctRj = rj / faturamentoTotal * 100;
            double pctMg = mg / faturamentoTotal * 100;
            double pctEs = es / faturamentoTotal * 100;
            double pctOutros = outros / faturamentoTotal * 100;

            Console.WriteLine("Percentual de faturamento por estado:");
            Console.WriteLine("SP: " + pctSp.ToString("0.00") + "%");
            Console.WriteLine("RJ: " + pctRj.ToString("0.00") + "%");
            Console.WriteLine("MG: " + pctMg.ToString("0.00") + "%");
            Console.WriteLine("ES: " + pctEs.ToString("0.00") + "%");
            Console.WriteLine("Outros: " + pctOutros.ToString("0.00") + "%");
        }
    }
}
