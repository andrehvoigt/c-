using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Pedro", 1000, "Estagiario");



            funcionario1.AumentarSalario(0.15);
            funcionario1.ExibirDados();
        }

   
    }
}
