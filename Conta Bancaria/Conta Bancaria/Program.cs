using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("Victor",12345, 0);

            conta.Sacar(600);
            conta.Depositar(500);
            conta.Sacar(200);
            conta.ExibirDados();


        }
    }
}
