using System;

class Program
{
    static int LerVendas(string mensagem)
    {
        int vendas;
        Console.Write(mensagem);
        while (!int.TryParse(Console.ReadLine(), out vendas))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            Console.Write(mensagem);
        }
        return vendas;
    }

    static void Main()
    {
        // Entrada dos valores de vendas
        int m1 = LerVendas("Digite as vendas do mês 1: ");
        int m2 = LerVendas("Digite as vendas do mês 2: ");
        int m3 = LerVendas("Digite as vendas do mês 3: ");

        // Cálculo da venda média diária
        int vmd = ((m1 + m2 + m3) / 3) / 25;

        // Entrada do TR e cálculo do estoque mínimo
        int tr = LerVendas("Digite o TR: ");
        int emin = tr * vmd;

        // Entrada do LR e cálculo do estoque máximo
        int lr = LerVendas("Digite o LR: ");
        int emax = lr + emin;

        // Entrada do EA e lógica de compra
        int ea = LerVendas("Digite o EA: ");

        if (ea > emin)
        {
            Console.WriteLine("Não há necessidade de comprar");
        }
        else
        {
            Console.WriteLine("É necessário comprar");
        }

        // Exibindo resultados
        Console.WriteLine($"A venda média diária foi {vmd}, o estoque mínimo foi {emin}, o estoque máximo foi {emax}.");
    }
}
