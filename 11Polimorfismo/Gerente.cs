using System;

namespace _11Polimorfismo
{
    public class Gerente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto gerente do vale alimentação R$" + (salario * 0.15));
        }
    }
}