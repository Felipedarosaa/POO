using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_05
{
    public class Cidade
    {

        public int Id {get; set;}
        public string Nome {get; set;}


        public Cidade(int id, string nome) 
        {
            this.Id = id;
            this.Nome = nome;
        }




        
    }
}