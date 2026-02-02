using System;
using FinanceHub.Domain.entities;
using FinanceHub.Domain.Enums;

// 1. PADRONIZAÇÃO: O namespace deve ser o mesmo do projeto
namespace FinanceHub.Domain.Entities 
{
    public class Transacao
    {
        // Construtor
        public Transacao(string descricao, decimal valor, DateTime data, TipoTransacao tipo, Guid contaId, Guid categoriaId)
        {
            // Fail Fast Validation
            Validar(descricao, valor, contaId, categoriaId);

            Id = Guid.NewGuid();
            Descricao = descricao;
            Valor = valor;
            Data = data;
            Tipo = tipo;
            ContaId = contaId;
            CategoriaId = categoriaId;
        }

        // 2. ENCAPSULAMENTO: 'private set' protege a integridade dos dados
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }
        public TipoTransacao Tipo { get; private set; }

        // Foreign Keys
        public Guid ContaId { get; private set; }
        public Guid CategoriaId { get; private set; }

        // Propriedades de Navegação (EF Core)
        public virtual Conta Conta { get; set; } = null!; // lazy loading EF core
        public virtual Categoria Categoria { get; set; } = null!;

        // Validações
        private void Validar(string descricao, decimal valor, Guid contaId, Guid categoriaId)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("A descrição é obrigatória.");

            if (valor <= 0)
                throw new ArgumentException("O valor da transação deve ser maior que zero.");

            if (contaId == Guid.Empty)
                throw new ArgumentException("A transação precisa estar vinculada a uma conta.");

            if (categoriaId == Guid.Empty)
                throw new ArgumentException("A transação precisa ter uma categoria.");
        }
    }
}