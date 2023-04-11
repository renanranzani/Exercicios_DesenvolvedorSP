using Exercicios_DesenvolvedorSP.Interfaces;
using System.Text.Json;

namespace Exercicios_DesenvolvedorSP.Factory
{
    internal class FaturamentoDiario : IFaturamentoDiario
    {
        public void CalculoFaturamento()
        {
            double[] faturamentoDiario = { 1000.50, 1500.00, 800.30, 2000.80, 1200.10, 0, 0, 900.50, 1800.20, 1300.90, 0, 1100.70,
                               1400.40, 0, 1600.60, 1700.10, 900.80, 1800.30, 0, 1100.90, 1900.20, 1400.70, 0, 1300.50,
                               1200.80, 2000.40, 1500.10, 1100.60, 0, 900.70, 1400.20 };

            double menorFaturamento = faturamentoDiario[0];
            double maiorFaturamento = faturamentoDiario[0];

            for (int i = 1; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] < menorFaturamento)
                {
                    menorFaturamento = faturamentoDiario[i];
                }
                if (faturamentoDiario[i] > maiorFaturamento)
                {
                    maiorFaturamento = faturamentoDiario[i];
                }
            }

            double somaFaturamento = 0;
            int numDiasComFaturamento = 0;
            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] > 0)
                {
                    somaFaturamento += faturamentoDiario[i];
                    numDiasComFaturamento++;
                }
            }
            double mediaAnual = somaFaturamento / numDiasComFaturamento;

            int numDiasAcimaDaMedia = 0;
            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] > mediaAnual)
                {
                    numDiasAcimaDaMedia++;
                }
            }

            var result = new
            {
                menorFaturamento = menorFaturamento,
                maiorFaturamento = maiorFaturamento,
                numDiasAcimaDaMedia = numDiasAcimaDaMedia
            };

            string jsonString = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });


            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Faturamento Diário.json");
            File.WriteAllText(path, jsonString);

            Console.WriteLine("Faturamento pronto para impressão");
        }
    }
}
