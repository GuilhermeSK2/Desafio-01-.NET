using System;

class Exemplo14
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se um número é negativo ou positivo!");
        Console.WriteLine("Digite um número:");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("A Raiz quadrada do número " + numero + " é " + (Math.Sqrt(numero)));
        }
        else
        {
            Console.WriteLine("O número " + numero + " ao quadrado é " + (numero * numero));
        }
    }
}
