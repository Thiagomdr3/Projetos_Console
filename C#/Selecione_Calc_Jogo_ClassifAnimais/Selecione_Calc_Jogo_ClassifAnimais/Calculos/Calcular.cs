using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecione_Calc_Jogo_ClassifAnimais.Calculos
{
    class Calcular
    {
        public static void SelecionarCalc()
        {
            Console.Clear();
            Console.WriteLine("Você selecionou calcular!" +
                "\n\nVamos lá!! Selecione uma das opções abaixo:\n" +
                "\n1. Tabuada de um numero especifico;" +
                "\n2. Tabuada de todos os numeros do 1 ao 10;" +
                "\n3. Calcular o fatorial de um numero;" +
                "\n4. Voltar.");

            int i  = int.Parse(Console.ReadLine());

            
        }
    }
}
