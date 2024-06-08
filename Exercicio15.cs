using System;

class Exemplo15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir seu IMC!");
        Console.WriteLine("Digite seu peso:");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua altura");
        double altura = double.Parse(Console.ReadLine());
        double imc =  peso / (altura * altura);
        if (imc < 18.5)
        {
            Console.WriteLine("Seu IMC é " + imc + ", isso significa que você está abaixo do peso!");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Seu IMC é " + imc + ", isso significa que você seu peso está normal!");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Seu IMC é " + imc + ", isso significa que você está com sobrepeso!");
        }
        else if (imc >= 30 && imc <= 34.9)
        {
            Console.WriteLine("Seu IMC é " + imc + ", isso significa que você está com grau de obesidade I !");
        }
        else if (imc >= 35 && imc <= 39.9)
        {
            Console.WriteLine("Seu IMC é " + imc + ", isso significa que você está com grau de obesidade II !");
        }
        else if (imc >= 40)
        {
            Console.WriteLine("Seu IMC é " + imc + ", isso significa que você está com grau de obesidade III !");
        }
    }
}