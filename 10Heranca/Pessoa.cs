using System;

namespace _10Heranca
{
    public class Pessoa
    {
        //atributo: apenas a classe e a herdeira
        protected string nome;
        protected int idade;

        //método
        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
        }
    }
}