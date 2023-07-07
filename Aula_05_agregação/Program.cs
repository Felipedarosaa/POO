using Aula_05;

Cidade cidade = new Cidade(11, "Torres");


Pessoa obj = new Pessoa(12, "Felipe", cidade);
obj.AddEndereco(new Endereco(1, "Centro"));

foreach (var item in obj.Enderecos)
{
    
}


PessoaFisica fisica = new PessoaFisica(1212, "Rosa", cidade, "03751418040");