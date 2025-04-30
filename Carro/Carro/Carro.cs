using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    internal class Carro
    {
        public string Modelo;
        public int VelocidadeAtual;
        public int VelocidadeMaxima;

        //metodo construtor

        public Carro(string Modelo,int VelocidadeAtual,int VelocidadeMaxima)
        {
            this.Modelo = Modelo;
            this.VelocidadeAtual = VelocidadeAtual;
            this.VelocidadeMaxima = VelocidadeMaxima;
        }

        public void Acelerar()
        {
            if (VelocidadeAtual + 10 <= VelocidadeMaxima)
            {
                VelocidadeAtual += 10;
                Console.WriteLine($"{Modelo} acelerou para {VelocidadeAtual} km/h.");
            }

        }

        public void Frear()
        {
            if(VelocidadeAtual - 10 >= 0)
            {
                VelocidadeAtual -= 10;
                Console.WriteLine($"{Modelo} reduziu para {VelocidadeAtual} km/h.");
            }
        }

        public void ExibirVelocidade()
        {
            Console.WriteLine($"Velocidade atual do {Modelo}: {VelocidadeAtual} km/h.");
        }

       
    }
}
