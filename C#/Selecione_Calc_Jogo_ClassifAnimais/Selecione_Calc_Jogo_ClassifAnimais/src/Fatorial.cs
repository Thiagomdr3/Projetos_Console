using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecione_Calc_Jogo_ClassifAnimais.src
{
    class Fatorial
    {
        public static void Iniciar()
        {
            int sair = 1;
            while(sair == 1)
            {
                Console.Clear();
                Console.Write("Voce selecionou a opção ");
                EscreverMensagem();
                Console.WriteLine("\n\nDigite um numero para calcularmos o fatorial:");
                int numero = 0;
                try
                {
                    numero = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nVocê digitou uma opção invalida. Tente novamente.");
                }
                if(numero != 0)
                {
                    int resultado = Calcular(numero);
                    Console.WriteLine("\nO fatorial de {0} é {1}", numero, resultado);
                }                
                Console.WriteLine("\nDeseja calcular o fatorial de outro numero? (1 = sim ou 2 = voltar ao menu anterior)");
                sair = int.Parse(Console.ReadLine());
            }
        }
        public static int Calcular(int numero)
        {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i; 
            }

            return resultado;
        }

        public static void EscreverMensagem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Calcular o fatorial de um número");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
