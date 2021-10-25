using System;
class Program
{
    static void Main(string[] args)
    {

        //ExibindoSemCalculo();
        ExibindoComCalculo();
    }

    static void ExibindoSemCalculo()
    {

        int inicial = 1000, qtd = 50;
        for (int i = 0; i < qtd; i++, inicial -= 3)
        {
            if (i == qtd - 1)
            {
                Console.Write("{0} / {1} ", inicial, i + 1);
                break;
            }
            if (i % 2 == 0)
            {
                Console.Write("{0} / {1} - ", inicial, i + 1);
            }
            else
            {
                Console.Write("{0} / {1} + ", inicial, i + 1);
            }

        }
    }

    static void ExibindoComCalculo()
    {
        double resultFinal = 0, resultBackup;
        double inicial = 1000, qtd = 50;
        for (int i = 1; i <= qtd; i++, inicial -= 3)
        {
            double result = inicial / i;

            if (i % 2 == 0)
            {
                resultBackup = resultFinal;
                resultFinal -= result;
                Console.WriteLine("{0} - {1} / {2} = {3} ", Math.Round(resultBackup, 2), inicial, i, Math.Round(resultFinal, 2));
            }
            else
            {
                resultBackup = resultFinal;
                resultFinal += result;
                Console.WriteLine("{0} + {1} / {2} = {3} ", Math.Round(resultBackup, 2), inicial, i, Math.Round(resultFinal, 2));
            }
        }
        Console.WriteLine("\n____________________\nResultado =" + resultFinal);
    }


}