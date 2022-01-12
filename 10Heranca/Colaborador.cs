using System;

namespace _10Heranca
{
    public class Colaborador : Pessoa
    {
        //atributo
        private double salario;

        //construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

            mensagemPessoa();
            mensagemColaborador();
        }

        //método
        protected void mensagemColaborador()
        {
            Console.WriteLine("Salario: " + salario);
        }
    }
}