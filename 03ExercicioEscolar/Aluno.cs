using System;

namespace _03ExercicioEscolar
{
    public class Aluno
    {
        //atributos
        public string nome;
        public double nota1, nota2;

        //Métodos média
        public double media()
        {
            return (nota1 + nota2) / 2;
        }

        //Métodos situação
        public string situacao(double media)
        {
            return media >= 7 ? "Aprovado" : "Reprovado";
        }

        //Métodos Mensagem
        public void mensgem()
        {
            //obter a média
            double obterMedia = media();

            //obter situação
            string obterSituacao = situacao(obterMedia);

            //mensagem
            Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
        }
    }
}