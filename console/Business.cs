using System;
using System.Collections.Generic;

namespace LegacySystem
{
    class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Cliente(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataCadastro = DateTime.Now;
        }

        public void AtualizarNome(string novoNome)
        {
            if (!string.IsNullOrEmpty(novoNome))
            {
                Nome = novoNome;
            }
        }

        public void AtualizarEmail(string novoEmail)
        {
            if (!string.IsNullOrEmpty(novoEmail) && novoEmail.Contains("@"))
            {
                Email = novoEmail;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Id: {Id} Nome: {Nome} Email: {Email} Cadastro: {DataCadastro}");
        }
    }

    class Transacao
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }

        public Transacao(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
            Data = DateTime.Now;
        }

        public void ExibirTransacao()
        {
            Console.WriteLine($"Id: {Id} Valor: {Valor} Descricao: {Descricao} Data: {Data}");
        }
    }

    class SistemaTransacoes
    {
        private List<Transacao> _transacoes = new List<Transacao>();

        public void AdicionarTransacao(int id, decimal valor, string descricao)
        {
            _transacoes.Add(new Transacao(id, valor, descricao));
        }

        public void ExibirTransacoes()
        {
            foreach (var transacao in _transacoes)
            {
                transacao.ExibirTransacao();
            }
        }
    }

    class SistemaCliente
    {
        private List<Cliente> _clientes = new List<Cliente>();

        public void AdicionarCliente(int id, string nome, string email)
        {
            _clientes.Add(new Cliente(id, nome, email));
        }

        public void RemoverCliente(int id)
        {
            var cliente = _clientes.Find(x => x.Id == id);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
            }
        }

        public void ExibirTodosOsClientes()
        {
            foreach (var cliente in _clientes)
            {
                cliente.ExibirDados();
            }
        }

        public void AtualizarNomeCliente(int id, string novoNome)
        {
            var cliente = _clientes.Find(x => x.Id == id);
            cliente?.AtualizarNome(novoNome);
        }
    }

    class Relatorio
    {
        public void GerarRelatorioClientes(List<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Cliente: {cliente.Nome} | Email: {cliente.Email}");
            }
        }
    }
}
