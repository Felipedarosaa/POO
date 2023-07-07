// Crie um programa que calcule a média de três notas informadas pelo usuário. Em seguida, imprima na tela a média calculada.


        Console.WriteLine("Digite a 1ª nota" );
        var nota1 = Convert.ToDouble(Console.ReadLine()); 

         Console.WriteLine("Digite a 2ª nota" );
        var nota2 = Convert.ToDouble(Console.ReadLine()); 

         Console.WriteLine("Digite a 3ª nota" );
        var nota3 = Convert.ToDouble(Console.ReadLine()); 


        double media = 0;
        media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("A média das notas é: " + media);