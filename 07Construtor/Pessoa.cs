using System;

namespace _07Construtor
{
    public class Pessoa
    {

        //construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá " + nome);

        }

    }
}