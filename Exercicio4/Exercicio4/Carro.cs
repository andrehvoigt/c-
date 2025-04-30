using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Carro
    {
        public string Modelo;
        public int VelocidadeAtual;
        public int VelocidadeMaxima;

        //metodo construtor
        public Carro(string Modelo, int VelocidadeAtual, int VelocidadeMaxima)
        {
            this.Modelo = Modelo;
            this.VelocidadeAtual = VelocidadeAtual;
            this.VelocidadeMaxima = VelocidadeMaxima;
        }


        public void Acelerar()
        {
            if(VelocidadeAtual + 10 <= VelocidadeMaxima)
            {
                VelocidadeAtual += 10;
            }
            else{
                Console.WriteLine("Ultrapassou a velocidade Maxima");
            }
        }
        
        public void Freiar()
        {
            if (VelocidadeAtual - 10 > 0)
            {
                VelocidadeAtual -= 10;

            }
            else
            {
                Console.WriteLine("Erro");
            }
        }
        
        public void ExibirVelocidade()
        {
            Console.WriteLine(VelocidadeAtual);


        }
    }
}
