using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar estagiário
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("---------");

            //Instanciar gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            Console.WriteLine("---------");

            //Instanciar atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
        }
    }
}
