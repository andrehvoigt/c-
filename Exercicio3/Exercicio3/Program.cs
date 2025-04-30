using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria(12345,0,"Alan");

            conta1.Depositar(500);
            conta1.Sacar(200);
            conta1.ConsultarSaldo();
            
        }
    }
}
