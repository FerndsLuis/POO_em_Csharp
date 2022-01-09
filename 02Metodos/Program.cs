using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.apresentar();
            p.apresentar("Luís");
            p.apresentar("Luís", 28);
        }
    }
}
