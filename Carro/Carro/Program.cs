using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Ferrari", 100, 350);


            Console.WriteLine("\n--- Acelerando ---");
            for (int i = 1; i <= 3; i++)
            {
                carro1.Acelerar();
                Console.WriteLine($"Aceleração {i}: {carro1.VelocidadeAtual} km/h");
            }

            Console.WriteLine("Freiando");
            carro1.Frear();
            Console.WriteLine($"Freiando para {carro1.VelocidadeAtual}");

        }
    }
}
