using System;

class Program
{
    public static void Main(string[] args)
    {
        double literGasoline = 3.30;
        double literAlcohol = 2.90;

        Console.Write("Alcool ou Gasolina? ");
        string alcoolOuGasolina = Console.ReadLine();

        Console.Write("Quantos litros? ");
        double quantosLitros = Convert.ToDouble(Console.ReadLine());

        double desconto = 0;
        double precoTotal;

        if (alcoolOuGasolina.ToLower() == "alcool")
        {
            if (quantosLitros <= 20)
              desconto = literAlcohol * 0.03;
            else
                desconto = literAlcohol * 0.05;
            
            precoTotal = (literAlcohol * quantosLitros) - desconto;
        }
        else if (alcoolOuGasolina.ToLower() == "gasolina")
        {
            if (quantosLitros <= 20)
                 desconto = literGasoline * 0.04;
            else
                desconto = literGasoline * 0.06;
            
            precoTotal = (literGasoline * quantosLitros) - desconto;
        }
        else
        {
            Console.WriteLine("Tipo de combustível inválido.");
            return;
        }

        Console.WriteLine($"O valor a ser pago pelo cliente é: {precoTotal:F2}");
    }
}
