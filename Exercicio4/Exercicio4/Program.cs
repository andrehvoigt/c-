using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Ferrari", 110, 350);

            //1 acelerada
            Console.Write("Primeira Acelerada: ");
            carro1.Acelerar();
            carro1.ExibirVelocidade();

            // 2 acelerada
            Console.Write("Segunda Acelerada: ");
            carro1.Acelerar();
            carro1.ExibirVelocidade();

            //3 acelerada
            Console.Write("Terceira Acelerada: ");
            carro1.Acelerar();
            carro1.ExibirVelocidade();

            //4 acelerada
            Console.Write("Velocidade depois de Freiar: ");
            carro1.Freiar();
            carro1.ExibirVelocidade();

            //Velocidade Atual
            Console.Write("Velocidade Atual: ");
            carro1.ExibirVelocidade();
        }
    }
}
