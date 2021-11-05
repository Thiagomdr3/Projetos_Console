using System;
using System.Collections;
using System.Collections.Generic;
using ControleEStoque.src;
using static System.Console;

namespace ControleEStoque
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntddItens;
            List<Estoque> estoque = new();
            Console.WriteLine("Quantos itens deseja inserir no estoque?");
            qntddItens = int.Parse(Console.ReadLine());

            
            estoque =  Estoque.NewItem(qntddItens);

            foreach(Estoque iten in estoque)
            {
                Console.WriteLine("id = {0} - item = {1} - quantidade = {2}", iten._id, iten._item, iten._quantidade);
            }
        }
    }
}
