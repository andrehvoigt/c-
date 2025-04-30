using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class ContaBancaria
    {
        public int NumeroConta;
        public double saldo;
        public string titular;


        //metodo Construtor

        public ContaBancaria(int NumeroConta, double saldo,string titular)
        {
            this.NumeroConta = NumeroConta;
            this.saldo = saldo;
            this.titular = titular;
        } 

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Deposito Realizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Erro o valor deve ser maior que 0");
            }
        }
        public void Sacar(double valor)
        {
            if(saldo > valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com Sucesso");
            }
            else
            {
                Console.WriteLine("Valor Indisponivel");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Numero da Conta: {NumeroConta}");
            Console.WriteLine($"Saldo: ${saldo}");
        }
    }
}
