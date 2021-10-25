using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecione_Calc_Jogo_ClassifAnimais.Controller
{
    class Menu
    {
        public static void Iniciar()
        {
            int sair = 1;
            while (sair == 1)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo!!!" +
                "\n\nEscolha uma das opções abaixo:\n" +
                "\n1. Calcular;" +
                "\n2. Jogar;" +
                "\n3. Classificar Animais;" +
                "\n4. Sair.");

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
                        Calculos.Selecionar();
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        sair = 0;
                        Console.WriteLine("Fim do código");
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
                                else if (opcao == 1)
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
