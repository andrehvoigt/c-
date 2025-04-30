using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Aluno
    {
        public string Nome;
        public int Matricula;
        public double Nota;


        //metodo construtor 
        public Aluno(string Nome, int Matricula, double Nota) 
        { 
            this.Nome = Nome;
            this.Matricula = Matricula;
            this.Nota = Nota;
        }

        public void ExibirDados()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Matricula);
            Console.WriteLine(Nota);
        }
        
        public void Aprovar()
        {
            if (Nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado"); 
            }
        }
    }
}
