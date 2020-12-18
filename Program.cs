using System;
using POO_Interfaces.classes;

namespace POO_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAR CARRINHO
            Carrinho carrinho = new Carrinho();

            // CASDASTRAR PRODUTO
            // DIFERENTE DE INSTANCIAR
            Produto p1 = new Produto();

            // ATRIBUTOS
            p1.Nome    = "Farinha";
            p1.Preco   = 5.50f;
            p1.Codigo  = 1;

            
            Produto p2 = new Produto();
            p2.Nome    = "Açúcar";
            p2.Codigo  = 2;
            p2.Preco   =4.5f;

            Produto p3 = new Produto();
            p3.Nome    = "Fermento";
            p3.Codigo  = 3;
            p3.Preco   = 4f;

            Produto p4 = new Produto();
            p4.Nome    = "ovo";
            p4.Codigo  = 4;
            p4.Preco   = 0.5f;
 
            Produto p5 = new Produto();
            p5.Nome    = "oleo"; 
            p5.Codigo  = 5;
            p5.Preco   = 9f;
            
            // CADASTRANDO PRODUTOS DO CARRINHO
            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Cadastrar(p4);

            Console.ForegroundColor = ConsoleColor.DarkBlue;  
              // mudar cor da fonte 
            Console.WriteLine("Primeira lista");
            System.Console.WriteLine();
            Console.ResetColor();                           // restornar cor da fonte

            // LISTAR PRODUTOS DO CARRINHO
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Red;    
            System.Console.WriteLine();
            Console.WriteLine("Lista Alterada");
            System.Console.WriteLine();
            Console.ResetColor();

            // ALTERAR PRODUTO
            Console.ForegroundColor = ConsoleColor.Yellow;
            carrinho.Alterar(p1.Codigo, p5);
            carrinho.Listar();
            Console.ResetColor();
        }
    }
}
