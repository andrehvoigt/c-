using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public string Cargo;

        //metodo construtor

        public Funcionario(string Nome,double Salario,string Cargo)
        {
            this.Nome = Nome;
            this.Salario = Salario;
            this.Cargo = Cargo;
        }  

        public void AumentarSalario(double Percentual)
        {
            if (Percentual > 0)
            {
                Salario += Salario * Percentual;
                Console.WriteLine($"Aumento de {Percentual}");
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} ");
            Console.WriteLine($"Salario: {Salario} ");
            Console.WriteLine($"Cargo: {Cargo} ");
        }
    }
}
