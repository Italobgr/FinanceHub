using System;

namespace FinanceHub.Domain.entities
{
    
    public class Conta
    {

     public Conta(string nome,decimal saldoInicial, bool ativa = true)
     {
        
        Id = Guid.NewGuid();
        Nome = nome;
        Saldo = saldoInicial;
        Ativa = ativa;

     }

     public Guid Id { get; private set; }
     public string Nome { get; private set; }
     public decimal Saldo { get; private set; }
     public bool Ativa { get; private set; }
    

    public void AtualizarNome(string nome)
        {
            
            Nome = nome;
        }

    


    // a prop Saldo continua privada so esse metodo mexe nela//
    public void Depositar(decimal valor)
        {
            if(valor <= Saldo)
            {
                throw new ArgumentException("O valor do deposito tem que ser maior do que o Saldo");
            }
            Saldo = valor;
        }

        public void Sacar(decimal retirada)
        {

            if(retirada >= Saldo)
            {
                throw new ArgumentException("Não e Possivel Sacar um valor maior que o Saldo atual!");
            }
            Saldo -= retirada;
        }

        public void Desativar()
        {
            if (Saldo > 0)
            {
                throw new ArgumentException("Não e Possivel Desativar uma Conta com saldo positivo!");
            }
        }


    public void Validar(string nome)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("A Conta deve ter um nome!");
            }

            if(nome.Length < 3)
            {
                throw new ArgumentException("O Nome da conta deve ser maior que 3 Caracteres");
            }
        }


    }

}