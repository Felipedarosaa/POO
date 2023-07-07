// Crie uma classe base chamada "Animal" que tenha uma propriedade "Nome" e um método "Falar()". Em seguida, crie duas classes derivadas chamadas "Cachorro" e "Gato" que herdam da classe "Animal" e implementam o método "Falar()" de maneiras diferentes. Por exemplo, o método "Falar()" da classe "Cachorro" pode imprimir "Au au!", enquanto o método "Falar()" da classe "Gato" pode imprimir "Miau!". A classe animal não poderá ser instanciada. Teste o código na classe program.
using System;

// Chamando a classe Cachorro
Cachorro cachorro = new Cachorro();
cachorro.Nome = "Zeca";
cachorro.Falar(); // "Zeca: Au au!"

// Chamando a classe Gato
Gato gato = new Gato();
gato.Nome = "Elvis";
gato.Falar(); // "Elvis: Miau!"


Console.WriteLine("");
// Chamando a classe Animal, porém sem nenhuma espécie explícita
Animal animal = new Animal();
animal.Nome = "Sem espécie";
animal.Falar(); // Nenhum animal selecionado