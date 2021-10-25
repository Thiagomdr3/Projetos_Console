using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Selecione_Calc_Jogo_ClassifAnimais.Service
{
    class Tabuada
    {
        public static int[] Calc(int i)
        {
            int[] tabuada = new int[11];
            for (int v = 0; v <= 10; v++)
            {
                tabuada[v] = i * v;
            }
            return tabuada;
        }

        public static void Mostrar(int num, int[] tabuada)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, tabuada[i]);
            }
        }
        public static void Iniciar()
        {

            int sair = 1;
            Console.Clear();
            while (sair == 1)
            {
                Console.WriteLine(@"Você selecionou a opção ""1.Tabuada de um número específico"".");
                Console.WriteLine("\n\n Vamos lá?\n" +
                    "\nDigite o número inteiro o qual deseja realizar a tabuada:");

                int num = 0;
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Você digitou um valor inválido.");
                    num = 0;
                }

                if (num != 0)
                {
                    int[] tabuada = new int[11];
                    tabuada = Calc(num);
                    Mostrar(num, tabuada);
                    int erro = 0;
                    while(erro == 0)
                    {
                        Console.WriteLine(@"Solução apresentada. Gostaria de fazer outra tabuada (digite 1) ou voltar ao menu ""Calculos""(dgite 0)");

                        try
                        {
                            sair = int.Parse(Console.ReadLine());
                            if (sair == 0 || sair == 1)
                            {
                                erro = 1;
                            }
                            else
                            {
                                Console.Clear();
                                erro = 0;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Voce digitou uma opção invalida. Voltaremos ao menu de Calculos em");
                            for (int i = 5; i > 0; i--)
                            {
                                Console.WriteLine(i);
                                Thread.Sleep(1000);
                            }
                            erro = 1;
                            sair = 0;

                        }
                    }

                }
                else
                {

                }
            }
        }
    }
}
