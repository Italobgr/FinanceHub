using System;
using System.Data.Common;
using System.Drawing;

namespace FinanceHub.Domain.entities
{
    // defiinindo dominio rico - contem alguns casos de uso

    public class Categoria
    {
        //Construtor Privado para obrigar o usa de metodos de criação(Factory/ Construtor Publico)
        // Isso garante que ninguém crie uma categoria inválida (sem nome, por exemplo)
        public Categoria(string nome, bool ativa)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Ativa = ativa;
        }


        //Private Set -> Encapsulamento
        //Ninguem de fora pode mudar o valor
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public bool  Ativa { get; private set; }



        public void AtualizarNome(string NovoNome)
        {
            ValidarCategoria(NovoNome);
            Nome = NovoNome;   
        }

        public void Ativar() => Ativa = true;
        public void Desativar() => Ativa = false;


        //Regra de negocio -> depois usar fluentValidation
        private void ValidarCategoria(string nome)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O Nome da Categoria e Obrigatorio");
            }

            if(nome.Length > 3)
            {
                throw new ArgumentException("O Nome da Categoria deve ser maior que 3");
            }
        }

    }
}