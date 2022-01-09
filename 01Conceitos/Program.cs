using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.nome = "Luís";
            p.idade = 28;

            p.mensagem();
        }
    }
}
