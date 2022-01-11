using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Nome = "Luis";

            Console.WriteLine(p.Nome);
        }
    }
}
