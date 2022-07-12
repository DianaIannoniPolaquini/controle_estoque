using System;
using System.Globalization;

namespace ESTOQUE_E_S_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();
           
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizados: {produto}");
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser retirado no estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}
