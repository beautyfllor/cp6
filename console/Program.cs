using System;
using System.Collections.Generic;
using System.IO;

namespace LegacySystem
{
    class MainSistema
    {
        static void Main(string[] args)
        {
            var sistemaCliente = new SistemaCliente();
            sistemaCliente.AdicionarCliente(1, "Joao", "joao@email.com");
            sistemaCliente.AdicionarCliente(2, "Maria", "maria@email.com");

            var sistemaTransacoes = new SistemaTransacoes();
            sistemaTransacoes.AdicionarTransacao(1, 100.50m, "Compra de Produto");
            sistemaTransacoes.AdicionarTransacao(2, 200.00m, "Compra de Serviço");
            sistemaTransacoes.AdicionarTransacao(3, 300.75m, "Compra de Software");

            sistemaCliente.ExibirTodosOsClientes();
            sistemaTransacoes.ExibirTransacoes();

            sistemaCliente.RemoverCliente(1);
            sistemaCliente.ExibirTodosOsClientes();
            sistemaCliente.AtualizarNomeCliente(2, "Maria Silva");

            var nomeEmpresa = "Empresa Teste";
            var descricaoTransacao = "Compra de Insumo";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nome da Empresa: {nomeEmpresa} Descrição: {descricaoTransacao}");
            }

            var relatorio = new Relatorio();
            relatorio.GerarRelatorioClientes(sistemaCliente.ExibirTodosOsClientes);

            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma total: " + soma);
        }
    }
}
