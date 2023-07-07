using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_05
{
    public class PessoaFisica : Pessoa
    {

        public string CPF { get; set; }

        public PessoaFisica(int id, string nome, Cidade cidade, string cpf) 
            : base(id, nome, cidade)
            {
                this.CPF = cpf;
            }

        public void TestNome() 
        {
            this.Nome = "João";
        }



        
    }
}