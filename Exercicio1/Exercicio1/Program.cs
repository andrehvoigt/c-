using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Victor", 12345, 8.5);

            aluno1.ExibirDados();
            aluno1.Aprovar();
        }
    }
}
