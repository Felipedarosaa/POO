// See https://aka.ms/new-console-template for more information
using Aula02_classe_objeto_construtor_metodos;


Livro livroBD = new Livro(123, "aaaaaaaaaaaaa", "Banco de Dados", 250.00);



    livroBD.Preco = 100; 
   Show(livroBD.Id + " - " + livroBD.Isbn + " - " + livroBD.Preco);



    Show("Digite algo: ");
    var retorno = Console.ReadLine();

    Show("Palavra do usuário: " + retorno);



    void Show(string msg) {
        Console.WriteLine(msg);
    }