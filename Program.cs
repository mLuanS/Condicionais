using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a idade: ");
        int idade;

        // Certifique-se de que o valor inserido seja um número inteiro
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.Write("Digite a idade: ");
        }

        // Classificar a idade em categorias
        if (idade >= 0 && idade <= 11)
        {
            Console.WriteLine("Você é uma criança.");
        }
        else if (idade >= 12 && idade <= 17)
        {
            Console.WriteLine("Você é um adolescente.");
        }
        else if (idade >= 18 && idade <=60)
        {
            Console.WriteLine("Você é um adulto.");
        }
        else
        {
            Console.WriteLine("Idoso");
        }
        Console.ReadLine();
    }
}
