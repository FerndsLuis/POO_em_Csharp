using System;

namespace _09This
{
    public class Pessoa
    {
        //atributo
        private string nome = "Tati";

        //construtor
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome); //estou chamando o atributo ao invés do parâmetro nome do construtor
        }
    }
}