using System;

namespace _01Conceitos
{
    public class Pessoa
    {
        //atributos
        public string nome;
        public int idade;

        //Métodos
        public void mensagem()
        {
            Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos");
        }
    }
}