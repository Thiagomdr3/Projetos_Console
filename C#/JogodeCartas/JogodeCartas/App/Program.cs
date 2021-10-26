using System;
using JogodeCartas.src;

namespace JogodeCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] cartas =  Baralho.Criar();

            foreach(string index in cartas)
            {
                if(index.Equals(""))
                Console.Write("  |" + index + "|   ");
                
            }

        }
    }
}
