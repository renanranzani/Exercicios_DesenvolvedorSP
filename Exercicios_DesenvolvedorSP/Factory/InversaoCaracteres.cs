using Exercicios_DesenvolvedorSP.Interfaces;

namespace Exercicios_DesenvolvedorSP.Factory
{
    internal class InversaoCaracteres : IInversaoCaracteres
    {
        public void InversaoDeCaracteres()
        {
            string str = "abcdefg";
            Console.WriteLine("String original: " + str);

            char[] charArray = str.ToCharArray();

            int i = 0;
            int j = charArray.Length - 1;
            while (i < j)
            {
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                i++;
                j--;
            }

            string reversedStr = new string(charArray);
            Console.WriteLine("String invertida: " + reversedStr);
        }
    }
}
