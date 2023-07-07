// Crie uma classe base chamada "Veiculo" que tenha uma propriedade "Modelo" e um método "Acelerar()". Em seguida, crie duas classes derivadas chamadas "Carro" e "Moto" que herdam da classe "Veiculo" e implementam o método "Acelerar()" de maneiras diferentes. Por exemplo, o método "Acelerar()" da classe "Carro" pode imprimir "Acelerando carro!", enquanto o método "Acelerar()" da classe "Moto" pode imprimir "Acelerando moto!". Teste o código na classe program.
using Aula06_herança_atividade02;

// Chamando a classe Carro
Carro carro = new Carro();
carro.Modelo = "BMW X6 M Competition";
carro.Acelerar(); // "Modelo: BMW X6 Competition. Acelerando o Carro"

// Chamando a classe Gato
Moto moto = new Moto();
moto.Modelo = "Kawasaki Ninja ZX-10R";
moto.Acelerar(); // "Modelo: Kawasaki Ninja ZX-10R. Acelerando a Moto"

Console.WriteLine("");

// Chamando a classe Veiculo, porém sem nenhum modelo explícito
Veiculo veiculo = new Veiculo();
veiculo.Modelo = "Sem modelo";
veiculo.Acelerar();