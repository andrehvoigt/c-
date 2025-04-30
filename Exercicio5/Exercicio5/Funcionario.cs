using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Funcionario
    {
        private string Nome;
        private double Salario;
        private string Cargo;

        //metodo Construtor

        public Funcionario(string Nome, double Salario, string Cargo)
        {
            this.Nome = Nome;
            this.Salario = Salario; 
            this.Cargo = Cargo;
        }

        public void AumentarSalario(double Percentual)
        {
            Salario += Salario * Percentual;

            
        }

        public void ExibirSalario()
        {
            Console.WriteLine($"Salario sem o aumento:${Salario} ");
        }

        public void ExibirDados()
        {
            Console.WriteLine("Dados: ");
            Console.WriteLine($"Nome:{Nome} ");
            Console.WriteLine($"Salario depois do:${Salario} ");
            Console.WriteLine($"Cargo:{Cargo} ");
        }

        
    }
}
