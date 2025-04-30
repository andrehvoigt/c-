using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Produto
    {
        public string Nome;
        public double Preço;
        public int EmEstoque;

        //metodo Construtor;

        public Produto(string Nome, double Preço, int EmEstoque)
        {
            this.Nome = Nome;
            this.Preço = Preço;
            this.EmEstoque = EmEstoque;
        }  
        public void AdicionarEstoque(int quantidade)
        {
            EmEstoque += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > EmEstoque)
            {
                Console.WriteLine("Erro quantiade em estoque Insuficiente");
            }
            else
            {
                EmEstoque -= quantidade;
            }
        }

        public void ExibirProduto()
        {
            Console.WriteLine($"Nome:{Nome} ");
            Console.WriteLine($"Preço:${Preço} ");
            Console.WriteLine($"Quantidade em Estoque:{EmEstoque} ");
        }
    }
}
