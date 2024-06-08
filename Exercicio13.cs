using System;

class Exemplo13
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos descobrir se você se o cliente tem desconto ou não na compra!");
        Console.WriteLine("Digite o valor da compra:");
        double valorCompra = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Agora informe a categoria do cliente!");
        Console.WriteLine("Digite o número da opção correspondente a categoria do cliente:");
        Console.WriteLine("1 - Comum (sem desconto)");
        Console.WriteLine("2 - Associado (10% de desconto)");
        Console.WriteLine("3 - VIP (20% de desconto)");
        int categoria = Convert.ToInt32(Console.ReadLine());
        double desconto = 0;

        if(categoria == 1)
        {
            desconto = 0;
        }
        else if (categoria == 2)
        {
            desconto = valorCompra * 0.10;
        }
        else if (categoria == 3)
        {
            desconto = valorCompra * 0.20;
        }
        else
        {
            Console.WriteLine("Categoria inválida! Nenhum desconto será aplicado!");
        }

        double valorFinal = valorCompra - desconto;
        Console.WriteLine("O valor final da compra é de R$ " + valorFinal);
    }
}
