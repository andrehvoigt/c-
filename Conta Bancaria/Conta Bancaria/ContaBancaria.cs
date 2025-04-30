using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    internal class ContaBancaria
    {
        public string Titular;
        public int NumeroDaConta;
        public double Saldo;

        //metodo construtor
        public ContaBancaria(string Titular, int NumeroDaConta, double Saldo)
        {
            this.Titular = Titular;
            this.NumeroDaConta = NumeroDaConta;
            this.Saldo = Saldo;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito de {valor} realizado com sucesso");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0) {
                if(Saldo > valor)
                {
                    Saldo -= valor;
                    Console.WriteLine($"O saque de {valor} foi realizado com sucesso");
                }
                else
                {
                    Console.WriteLine("O saque não foi realizado");
                }
            }
         }

        public void ExibirSaldo()
        {
            Console.WriteLine(Saldo);
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Numero da Conta: {NumeroDaConta}");
            Console.WriteLine($"Saldo:${Saldo}");
        }
    }
}

