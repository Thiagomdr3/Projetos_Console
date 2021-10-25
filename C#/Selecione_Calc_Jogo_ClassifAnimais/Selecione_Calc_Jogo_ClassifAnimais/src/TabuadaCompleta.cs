using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecione_Calc_Jogo_ClassifAnimais.src
{
    class TabuadaCompleta
    {
        public static void Iniciar()
        {
            Console.WriteLine("Você selecionou a opção: ");
            EscreverMensagem();
            Calcular();
            int i = int.Parse(Console.ReadLine());
        }

        public static void EscreverMensagem()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tabuada de todos os numeros do 1 ao 10;\n");
            Console.ForegroundColor = ConsoleColor.White;

            

        }

        public static void Calcular()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int v = 1; v <= 5; v++)
                {
                    int result = i * v;
                    string iv = Convert.ToString(result);
                    if (i == 10)
                    {
                        Console.Write("|{0} x {1} = {2}   ", v, i, (i * v));
                    }
                    else
                    {
                        if (iv.Length == 1)
                        {
                            Console.Write("|{0} x {1} = {2}     ", v, i, (i * v));
                        }
                        else if (iv.Length == 2)
                        {
                            Console.Write("|{0} x {1} = {2}    ", v, i, (i * v));
                        }
                        else if (iv.Length == 3)
                        {
                            Console.Write("|{0} x {1} = {2}", v, i, (i * v));
                        }
                    }


                }
                Console.Write("\n");
            }

            Console.WriteLine("_________________________________________________________\n");

            for (int i = 0; i <= 10; i++)
            {
                for (int v = 6; v <= 10; v++)
                {
                    int result = i * v;
                    string iv = Convert.ToString(result);
                    if (i == 10)
                    {
                        Console.Write("|{0} x {1} = {2}   ", v, i, (i * v));
                    }
                    else
                    {
                        if (iv.Length == 1)
                        {
                            Console.Write("|{0} x {1} = {2}     ", v, i, (i * v));
                        }
                        else if (iv.Length == 2)
                        {
                            Console.Write("|{0} x {1} = {2}    ", v, i, (i * v));
                        }
                        else if (iv.Length == 3)
                        {
                            Console.Write("|{0} x {1} = {2}", v, i, (i * v));
                        }
                    }


                }
                Console.Write("\n");
            }
        }
    }
}
