using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02
{
    public class Professor : IPessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine($"O professor {Nome} está falando.");
        }
    }   
}