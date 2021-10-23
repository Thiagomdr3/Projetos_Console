using System;
using Selecione_Calc_Jogo_ClassifAnimais.Calculos;

namespace Selecione_Calc_Jogo_ClassifAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            int sair = 1;

            while (sair == 1)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo!!!" +
                "\n\nEscolha uma das opções abaixo:\n" +
                "\n1. Calcular;" +
                "\n2. Jogar;" +
                "\n3. Classificar Animais");

                int selecao = 0;

                try
                {
                    selecao = int.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("\nVocê não digitou um valor numérico. Digite um valor válido:\n");
                }

                switch (selecao)
                {
                    case 1:
                        Console.Clear();
                        Calcular.SelecionarCalc();
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        
                        while (true)
                        {
                            int opcao = 0;
                            Console.WriteLine("Você digitou um valor invalido!!" +
                            "\nTentar novamente? (1 = Sim ___ 2 = Não");
                            try
                            {
                                opcao = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("\nVocê nao digitou um valor numérico. Digite um valor válido:\n");
                            }
                            if (opcao == 1 || opcao == 2)
                            {
                                if (opcao == 2)
                                {
                                    sair = 0;
                                    Console.WriteLine("Fim do código");
                                    break;
                                }
                                else if(opcao == 1)
                                {
                                    break;
                                }

                                
                            }
                        }
                        break;

                }
            }
        }
    }
}
