using System;

namespace _13Abstracao
{
    public class PessoaJuridica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de emprestimo para pessoa jurídica R$" + (valor * 0.2));
        }
    }
}
