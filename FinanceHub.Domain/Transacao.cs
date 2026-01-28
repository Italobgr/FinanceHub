using System;
using FinanceHub.Domain.Enums;

namespace Transacao.Domain.entities
{
    
    public class Transacao
    {

public Transacao(string descricao, decimal valor, DateTime data, TipoTransacao tipo, Guid contaId, Guid categoriaId)
        {          
            //função de validação

            Id = Guid.NewGuid();
            Descricao = descricao;
            Valor = valor;
            Data = data;
            Tipo = tipo;
            ContaId = contaId;
            CategoriaId = categoriaId;
        }

        public Guid Id { get; set; }
        public string Descricao  {get; set;}
        public decimal Valor { get; set; }
        public DateTime Data { get; set;}
        public TipoTransacao Tipo { get; set; }
        public Guid ContaId { get; set; }
        public Guid CategoriaId { get; set; }



    }
}