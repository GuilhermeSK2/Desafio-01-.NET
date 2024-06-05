using System;

class Exemplo07
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se você é uma Criança, Adulto ou Idoso");
        Console.WriteLine("Quantos anos você tem?");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade <= 0)
        {
            Console.WriteLine("Idade inválida!");
        }
        else if (idade > 0 && idade <= 12)
        {
            Console.WriteLine("Você é uma criança!");
        }
        else if (idade >= 7 && idade <= 17)
        {
            Console.WriteLine("Você é adolescente!");
        }
        else if (idade >= 18 && idade <= 59)
        {
            Console.WriteLine("Você é adulto!");
        }
        else 
        { 
            Console.WriteLine("Você é um idoso"); 
        }
    }
}