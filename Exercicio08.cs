﻿using System;

class Exemplo08
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir qual a nota conceito do aluno!");
        Console.WriteLine("Digite uma nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());
        if (nota >= 9)
        {
            Console.WriteLine("A nota conceito é A");
        }
        else if (nota >= 7 && nota < 9)
        {
            Console.WriteLine("A nota conceito é B");
        }
        else if (nota >= 5 && nota < 7)
        {
            Console.WriteLine("A nota conceito é C");
        }
        else if (nota >= 3 && nota < 5)
        {
            Console.WriteLine("A nota conceito é D");
        }
        else
        {
            Console.WriteLine("A nota conceito é F");
        }
    }
}