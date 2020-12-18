using System;
using System.Collections.Generic;

namespace POO_Interfaces.classes
{
    public class Carrinho : ICarrinho
    {
        public float VarTotal {get; set;}

        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _cod, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _cod).Nome  = produto.Nome;
            carrinho.Find(x => x.Codigo == _cod).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach (Produto p in carrinho)
            {
              
                Console.WriteLine($"{p.Codigo} Nome: {p.Nome} - Preço R$ {p.Preco}");
                
            }
        }
    }
}