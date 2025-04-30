using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Victor", 2000, "Programdor Junior");

            funcionario1.ExibirSalario();
            funcionario1.AumentarSalario(0.15);
            funcionario1.ExibirDados();

        }
    }
}
