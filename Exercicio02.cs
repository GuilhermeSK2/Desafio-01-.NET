using System;

class Exemplo02
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se o número é Positivo Negativo ou Zero!");
        Console.WriteLine("Digite um número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero == 0)
        {
            Console.WriteLine("O número " + numero + " é Zero!");
        }
        else if (numero > 0)
        {
            Console.WriteLine("O número " + numero + " é positivo!");
        }
        else
        {
            Console.WriteLine("O número " + numero + " é negativo!");
        }
    }
}
