using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selecione_Calc_Jogo_ClassifAnimais.Service;
using Selecione_Calc_Jogo_ClassifAnimais.src;

namespace Selecione_Calc_Jogo_ClassifAnimais.Controller
{
    class Calculos
    {
        public static void Selecionar()
        {
            int voltar = 1;

            while (voltar == 1)
            {
                int selecao = 0;
                Console.Clear();
                Console.WriteLine("Você selecionou calcular!" +
                    "\n\nVamos lá!! Selecione uma das opções abaixo:\n" +
                    "\n1. Tabuada de um numero especifico;" +
                    "\n2. Tabuada de todos os numeros do 1 ao 10;" +
                    "\n3. Calcular o fatorial de um numero;" +
                    "\n4. Voltar.");

                try
                {
                    selecao = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Você digitou um valor invalido, entre com um valor numérico.");
                }

                switch (selecao)
                {
                    case 1:
                        Tabuada.Iniciar();
                        break;
                        
                    case 2:
                        TabuadaCompleta.Iniciar();
                        break;

                    case 3:
                        break;

                    case 4:
                        voltar = 0;
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
                                    voltar = 0;
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
