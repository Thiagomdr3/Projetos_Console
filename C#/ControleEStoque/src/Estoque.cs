using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEStoque.src
{
    public class Estoque
    {


        public int _id { set; get; }
        public string _item { set; get; }
        public int _quantidade { set; get; }

        //public List<Estoque> estoques { get; set; }



        public static List<Estoque> NewItem(int qntddItens)
        {

            List<Estoque> lista = new();       

            for (int i = 0; i < qntddItens; i++)
            {
                Estoque item = new();
                Console.WriteLine("Informe o item:");
                item._id = new Random().Next(1, 150);
                item._item = Console.ReadLine();
                Console.WriteLine("Informe a quantidade:");
                item._quantidade = int.Parse(Console.ReadLine());

                lista.Add(item);
                

            }

            return lista;
        }


    }

}
