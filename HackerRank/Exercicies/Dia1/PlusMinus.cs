using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Exercicies.Dia1
{
    public class PlusMinus
    {

        public static void plusMinus(List<int> arr)
        {
            var ocorrenciasPositivas = 0.0;
            var ocorrenciasNegativas = 0.0;
            var ocorrenciasZero = 0.0;
            var listProporcao = new List<double>();
            foreach (var ocorrencia in arr)
            {

                if (ocorrencia == 0) ocorrenciasZero++;
                if (ocorrencia > 0) ocorrenciasPositivas++;
                if (ocorrencia < 0) ocorrenciasNegativas++;
            }

            Console.WriteLine((ocorrenciasPositivas / arr.Count).ToString("0.000000"));
            Console.WriteLine((ocorrenciasNegativas / arr.Count).ToString("0.000000"));
            Console.WriteLine((ocorrenciasZero / arr.Count).ToString("0.000000"));

        }

    }
}
