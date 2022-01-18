using System;

namespace _13Abstracao
{
    public class PessoaFisica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de emprestimo para pessoa física R$" + (valor * 0.1));
        }

    }
}