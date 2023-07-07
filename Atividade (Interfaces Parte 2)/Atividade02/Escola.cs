using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade02
{
    public class Escola
    {
        public void ApresentarPessoa(IPessoa pessoa)
        {
            pessoa.Falar();
        }
    }
}