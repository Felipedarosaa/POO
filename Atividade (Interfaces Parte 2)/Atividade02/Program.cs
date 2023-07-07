using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria instâncias das classes Professor e Aluno
            var professor = new Professor { Nome = "Felipe", Idade = 20 };
            var aluno = new Aluno { Nome = "Endriw", Idade = 20 };

            // cria instância da classe Escola
            var escola = new Escola();

            // chama o método ApresentarPessoa passando as instâncias de Professor e Aluno como parâmetro
            escola.ApresentarPessoa(professor);
            escola.ApresentarPessoa(aluno);

            Console.ReadKey();
        }
    }
}