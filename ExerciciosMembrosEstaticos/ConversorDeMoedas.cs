using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerciciosMembrosEstaticos
{
    class ConversorDeMoedas
    {
        public static double Iof = 0.06;

        public static double DolarReal(double qtd, double cotacao)
        {
            double total = qtd * cotacao;
            return total + total * Iof;
        }
    }
}
