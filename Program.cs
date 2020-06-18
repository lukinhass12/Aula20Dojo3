using System;

namespace Aula20Dojo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente lucca = new Cliente("NOME DO CLIENTE: Lucca", "LOCAL DE ENTREGA: R. dos deuses Nº 1000");
            System.Console.WriteLine(lucca.Nome);
            System.Console.WriteLine(lucca.EnderecoAtual);

            Restaurante Padawwans = new Restaurante("Padawans's-restaurante", "Rua dos Padawans Nº500");
            System.Console.WriteLine(Padawwans.NomeFantasia);
            System.Console.WriteLine(Padawwans.Endereco);

            Pedido produto = new Pedido("IITEM:pizza", "CLIENTE:Lucca", "RESTAURANTE:Padawans-restaurante", "PAGAMENTO:via débito");
            System.Console.WriteLine(produto.Item);
            System.Console.WriteLine(produto.cliente);
            System.Console.WriteLine(produto.restaurante);
            System.Console.WriteLine(produto.Pagamento);
        }


  
    }
}
