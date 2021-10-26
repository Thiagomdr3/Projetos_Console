using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecione_Calc_Jogo_ClassifAnimais.src
{
    class Jogos
    {
        public static void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("Voce digitou a opção: ");
            Console.WriteLine("\n\n Seleciona um dos jogos abaixo:" +
                "\n1. Adivinhe um numero");

            int opcao;
            try
            {
                opcao = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Você digtou uma opção inváida tente novamente.");
            }
        }

        public static void EscreverMensagem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Jogar");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
