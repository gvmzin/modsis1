using System;

Console.Write("Digite as vendas do mês 1: ") ;
int m1 ;
if (int.TryParse(Console.ReadLine(), out m1)) ;
Console.Write("Digite as vendas do mês 2: ");
int m2 ;
if (int.TryParse(Console.ReadLine(), out m2)) ;
Console.Write("Digite as vendas do mês 3: ");
int m3 ;
if (int.TryParse(Console.ReadLine(), out m3)) ;

int vmd = ((m1 + m2 + m3) / 3) / 25;

Console.Write("Digite o TR: ") ;
int tr ;
if (int.TryParse(Console.ReadLine(), out tr)) ;

int emin = tr * vmd;

Console.Write("Digite o LR ");
int lr;
if (int.TryParse(Console.ReadLine(), out lr)) ;

int emax = lr + emin;

Console.Write("Digite o EA ");
int ea;
if (int.TryParse(Console.ReadLine(), out ea))
{
    if (ea > emin)
    {
        Console.WriteLine("Não há necessidade de comprar");
        Console.WriteLine($"A venda média diária foi {vmd}, o estoque mínimo foi {emin}, o estoque máximo foi {emax}.");
    }
    else
    {
        Console.WriteLine("Não há necessidade de comprar");
        Console.WriteLine($"A venda média diária foi {vmd}, o estoque mínimo foi {emin}, o estoque máximo foi {emax}.");
    }
}
