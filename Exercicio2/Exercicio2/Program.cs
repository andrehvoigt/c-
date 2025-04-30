using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Mouse gamer", 179.99, 20);


            produto1.AdicionarEstoque(10);
            produto1.RemoverEstoque(3);
            produto1.ExibirProduto();
        }
    }
}
