using ConsoleApp1.entities;

namespace ConsoleApp1;

internal class program
{
    private static void Main(string[] args)
    {
        using var context = new entities.aplicação_financeiraDbContext();
        
        Console.WriteLine("== Salvando Aplicação Financeira ==");
        
        aplicação_financeira ap = new("LCA", 1000, true);
        
        context.aplicação_financeiraS.Add(ap);
        
        context.SaveChanges();

    }
}