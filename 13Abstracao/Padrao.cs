using System;

namespace _13Abstracao
{
    public abstract class Padrao
    {
        //obrigatório: pode ser público ou protegido
        public abstract void taxaEmprestimo(double valor);

        //Opcional
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança R$" + (valor * taxa));
        }
    }
}