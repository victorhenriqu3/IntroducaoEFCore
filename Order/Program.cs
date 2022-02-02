using System;
using OrderingSystem.Domain;
using OrderingSystem.ValuesObjects;

namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //inserirProduto();
            inserirVarios();
        }

        private static void inserirVarios()
        {
            var listaClientes = new[]
            {
                new Cliente
                {
                    Nome = "Teste1",
                    CEP = "01234567",
                    Cidade = "Teste",
                    Estado = "DF",
                    Telefone = "99999999999"
                },
                new Cliente
                {
                    Nome = "Teste2",
                    CEP = "01234567",
                    Cidade = "Teste",
                    Estado = "DF",
                    Telefone = "99999999999"
                }
            };
            using var db = new Data.ApplicationContext();
            db.Set<Cliente>().AddRange(listaClientes);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total de Registro(s):{registros}");
        }
        private static void inserirProduto()
        {
            var produto = new Produto
            {
                Descricao = "Produto Teste",
                CodigoBarras = "1234567891231",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaRevenda,
                Ativo = true
            };
            using var db = new Data.ApplicationContext();
            db.Set<Produto>().Add(produto);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total de Registro(s):{registros}");
        }
    }
}
