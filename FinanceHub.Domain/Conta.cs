using System;
using System.Data.Common;

namespace Conta.Domain.entities
{
    
    public class Conta
    {

     public Conta(string nome,decimal saldo, bool ativa)
     {
        
        Id = Guid.NewGuid();
        Nome = nome;
        Saldo = saldo;
        Ativa = ativa;

     }

     public Guid Id { get; private set; }
     public string Nome { get; private set; }
     public decimal Saldo { get; private set; }
     public bool Ativa { get; private set; }
    

    public void ValidarConta(string nome)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("A Conta deve ter um nome!");
            }

            if(nome.Count() < 3)
            {
                throw new ArgumentException("O Nome da conta deve ser maior que 3 Caracteres");
            }
        }


    }

}