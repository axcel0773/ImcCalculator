using System;

namespace ImcCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double imc;

            Console.WriteLine("Bem vindo a Calculadora de IMC");

            Console.WriteLine("Digite a sua altura: ");
            n1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite o seu peso: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            imc = (n2 / Math.Pow(n1, 2));

            if(imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            } else if(imc >= 20 && imc < 25) {
                Console.WriteLine("Peso ideal");
            } else
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}
