using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.altura = 1.78;
            p.peso = 78;

            p.mensagem();
        }
    }
}
