using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.nome = "Carlos";
            a.nota1 = 7;
            a.nota2 = 8;

            a.mensgem();
        }
    }
}
