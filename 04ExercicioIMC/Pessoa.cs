using System;

namespace _04ExercicioIMC
{
    public class Pessoa
    {
        //atributos
        public double altura;
        public double peso;

        public double valorImc()
        {
            return peso / (altura * altura);
        }

        public string imcPessoa(double imc)
        {

            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso normal";
            }
            else if (imc < 30)
            {
                return "Acima do normal";
            }
            else if (imc < 35)
            {
                return "Obsidade I";
            }
            else if (imc < 40)
            {
                return "Obsidade II";
            }
            else
            {
                return "Obsidade III";
            }
        }

        public void mensagem()
        {
            Console.WriteLine("Sua situação é " + imcPessoa(valorImc()) + ", o valor do IMC " + Math.Round(valorImc(), 2));
        }
    }
}