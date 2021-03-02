using System;
using System.Globalization;

namespace ExerciciosMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double r = ConversorDeMoedas.DolarReal(qtd, cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + r.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
